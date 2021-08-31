
public class LinearSearch {
    public static int findNum(int array[], int num){
        for(int i=0; i<array.length; i++){
            if(num == array[i]){
                return array[i];
            }
        }
        return -1;
    }
    
    
    //method optimized
    //it has a minor number of executions compared with the first method
    public static int findNum2(int array[], int num){
        for(int i=0; i<array.length; i++){
            if(array[i] == num){
                return array[i];
            }else{
                if(array[i] > num){
                    return -1;
                }
            }
            System.out.println("findNum2 EXECUTOU---");
        }
        return -1;
    }
}
