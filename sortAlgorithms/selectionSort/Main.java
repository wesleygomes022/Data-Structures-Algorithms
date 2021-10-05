
public class Main {
    public static void main(String[] args) {
        int array[] = {10, 8, 6, 4, 2, 0};
        printArray(array);
        System.out.println("---Após chamada ao Insertion Sort---");
        SelectionSort.selectionSort(array);
        printArray(array);
    }
    
    public static void printArray(int array[]){
        for(int i=0; i<array.length; i++){
            System.out.println("array["+i+"] == " + array[i]);
        }
    }
}
