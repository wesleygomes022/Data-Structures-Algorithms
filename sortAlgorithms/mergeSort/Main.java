
public class Main {
    public static void main(String[] args) {
        int[] sample = {10, 8, 6, 4, 2, 0};
        printArray(sample);
        System.out.println("\n\n");
        MergeSortSample.mergeSort(sample, sample.length);    
        printArray(sample);
        
    }
    
    public static void printArray(int array[]){
        for(int i=0; i<array.length; i++){
            System.out.println("array["+i+"] == " + array[i]);
        }
    }
}
