
public class Main {
    public static void main(String[] args) {
        int[] sample = {24, 9, 29, 14, 19, 27};
        printArray(sample);
        System.out.println("--------------------");
        QuickSort.quickSort(sample, 0, sample.length-1);
        printArray(sample);
        
    }
    
    public static void printArray(int array[]){
        for(int i=0; i<array.length; i++){
            System.out.println("array["+i+"] == " + array[i]);
        }
    }
}
