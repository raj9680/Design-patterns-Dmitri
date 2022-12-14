public class Demo {
    static void Main(string[] args) {
        
    // If we have to build a simple string that can be done by this way
        
    var hello = "Hello";
    var sb = new StringBuilder();
    sb.Append("<p>");
    sb.Append(hello);
    sb.Append("</p>");
    WriteLine(sb); // Output : <p>Hello</p>   
        
        
    // If we have to build a complex string that can be done by this way but it makes code more complex w.r.t. string complexity which is a bad approach
        
    var words= new[] {"hello", "world"};
    sb.clear();
    sb.Append("<ul>");
    foreach(var word in words) {
        sb.AppendFormat("<li>{0}</li>", word);
    }
    sb.Append("</ul>");
    WriteLine(sb);
   }
}