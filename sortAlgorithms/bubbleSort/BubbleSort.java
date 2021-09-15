
public class BubbleSort {
    
    public static void bubbleSort(int array[]){
        int tam = array.length;
        for(int i=0; i<tam; i++){
            for(int j=0; j<(tam-1); j++){
                if(array[j] > array[j+1]){
                   int temp = array[j];
                   array[j] = array[j+1];
                   array[j+1] = temp;
                }    
            }
        }
    }
}


