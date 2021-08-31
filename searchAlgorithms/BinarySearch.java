
public class BinarySearch {
    public static int binarySearch(int array[], int num){
        int inferior = 0;
        int superior = array.length-1;
        
        while(inferior <= superior){
            int meio = (inferior + superior)/2;
            if(num == array[meio]){
                return array[meio];
            }else{
                if(num < array[meio]){
                    superior = meio-1;
                }else{
                    inferior = meio+1;
                }        
            }
        }
        return -1;
    }
    
    public static int recursiveBinarySearch(int array[], int num, int inferior, int superior){
        if(inferior > superior){
            return -1;
        }else{
            int meio = (inferior + superior) / 2;
            if(num == array[meio]){
                return array[meio];
            }else{
                if(num < array[meio]){
                    return recursiveBinarySearch(array, num, inferior, meio-1);
                }else{
                    return recursiveBinarySearch(array, num, meio+1, superior);
                }
            }
        }
    }
}
