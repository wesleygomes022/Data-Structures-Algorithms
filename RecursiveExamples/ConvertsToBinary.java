
public class ConvertsToBinary {
    public static String ConvertsToBinary(int n){
        int a;
        if(n > 0){
            a = n%2;
            return ConvertsToBinary(n/2) + "" + a;
        }
        return "";
    }  
}
