
public class Main {
    public static void main(String[] args) {
        int array[] = {5, 6, 7, 2, 4, 1, 7};
        
        printArray(array);
        
        System.out.println("\nAfter Bubble Sort \n");
        BubbleSort.bubbleSort(array);
        
        printArray(array);
    }
    
    public static void printArray(int array[]){
        for(int i=0; i<array.length; i++){
            System.out.println("array["+i+"] == " + array[i]);
        }
    }
    
}
