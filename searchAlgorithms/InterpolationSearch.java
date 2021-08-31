
public class InterpolationSearch {
    //return the index in the array of the number provided 
    public static int buscaInterpolada(int array[], int num){
        int inicio = 0;
        int fim = array.length-1;
        double a = array[inicio];
        double b = array[fim];
        int meio = (int) (inicio + (fim - inicio)*((num - a) / (b - a)));
        return meio;
    }
}
