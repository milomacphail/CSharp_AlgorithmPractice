string insertDashes(string inputString) {            
  
    return Regex.Replace(inputString, @"\B", "-");
    
    
}

