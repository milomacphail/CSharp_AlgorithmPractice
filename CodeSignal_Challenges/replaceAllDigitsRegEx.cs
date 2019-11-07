string replaceAllDigitsRegExp(string input) {
    
    string modified = Regex.Replace(input, "[0-9]", "#" );

    return modified;
    
}
