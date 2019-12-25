string capitalizeVowelsRegExp(string x) {
    
    return Regex.Replace(x, "[aeiouy]", m => m.Value.ToUpper());
}
