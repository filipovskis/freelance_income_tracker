using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace ind_project_project.Core
{
    internal class ConfigChangedEventArgs : EventArgs
    {
        public string Key { get; }
        public object Value { get; }

        public ConfigChangedEventArgs(string key, object value)
        {
            Key = key;
            Value = value;
        }
    }

    internal class ConfigManager
    {
        public static ConfigManager Instance { get; } = new ConfigManager();

        private readonly string _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json");

        private Dictionary<string, object> _settings = new Dictionary<string, object>();

        public event EventHandler<ConfigChangedEventArgs>? ConfigChanged;

        private ConfigManager()
        {
            LoadDefaults();

            LoadFromFile();
        }

        private void LoadDefaults()
        {
            _settings["NonTaxableMinimum"] = 740.0;
            _settings["EstimatedTaxRate"] = 0.35;
            _settings["DefaultHourlyRate"] = 10.0;
        }

        private void LoadFromFile()
        {
            try
            {
                if (File.Exists(_filePath))
                {
                    string jsonString = File.ReadAllText(_filePath);

                    var deserialized = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonString);

                    if (deserialized != null)
                    {
                        foreach (var kvp in deserialized)
                        {
                            if (kvp.Value is JsonElement jsonElement)
                            {
                                _settings[kvp.Key] = GetValueFromJsonElement(jsonElement);
                            }
                            else
                            {
                                _settings[kvp.Key] = kvp.Value;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Failed to load config: {ex.Message}");
            }
        }

        private void SaveToFile()
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(_settings, options);

                File.WriteAllText(_filePath, jsonString);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Failed: {ex.Message}");
            }
        }

        private object GetValueFromJsonElement(JsonElement element)
        {
            switch (element.ValueKind)
            {
                case JsonValueKind.Number:
                    return element.GetDouble();
                case JsonValueKind.True:
                    return true;
                case JsonValueKind.False:
                    return false;
                case JsonValueKind.String:
                    return element.GetString() ?? "";
                default:
                    return element.ToString();
            }
        }

        public T Get<T>(string key)
        {
            if (_settings.TryGetValue(key, out var value))
            {
                return (T)Convert.ChangeType(value, typeof(T));
            }
            throw new KeyNotFoundException($"Failed to find '{key}'.");
        }

        public void Set(string key, object value)
        {
            if (!_settings.ContainsKey(key))
            {
                throw new KeyNotFoundException($"Failed to find '{key}'.");
            }

            if (!_settings[key].Equals(value))
            {
                _settings[key] = value;

                SaveToFile();

                ConfigChanged?.Invoke(this, new ConfigChangedEventArgs(key, value));
            }
        }
    }
}