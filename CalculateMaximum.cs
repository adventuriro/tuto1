# Example code to calculate the average of an array of integers
public static double calculateAverage(int[] numbers) {
    if (numbers == null || numbers.length == 0) {
        return 0;
    }
    int sum = 0;
    for (int number : numbers) {
        sum += number;
    }
    return (double) sum / numbers.length;
}
