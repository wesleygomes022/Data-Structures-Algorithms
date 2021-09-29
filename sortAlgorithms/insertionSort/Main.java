
public class Main {
    public static void main(String[] args) {
        int array[] = {6, 5, 4, 3, 2, 1};
        printArray(array);
        System.out.println("---Após chamada ao Insertion Sort---");
        InsertionSort.insertionSort(array);
        printArray(array);
    }
    
    public static void printArray(int array[]){
        for(int i=0; i<array.length; i++){
            System.out.println("array["+i+"] == " + array[i]);
        }
    }
}
