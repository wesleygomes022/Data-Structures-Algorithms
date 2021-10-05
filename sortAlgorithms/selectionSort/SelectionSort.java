
public class SelectionSort {
    public static void selectionSort(int array[]){
        int min, minIndex, temp;
        for(int j = 0; j < array.length - 1; j++){
            min = array[j];
            minIndex = j;
            for(int i = j+1; i < array.length; i++){
                if(array[i] < min){
                    min = array[i];
                    minIndex = i;
                }
            }
            
            temp = min;
            array[minIndex] = array[j];
            array[j] = temp;
        }
    }
}
