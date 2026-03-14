namespace cw1;

public class Utils {
    private static void ThrowIfEmpty<T>(T[] values) {
        if (values == null || values.Length == 0)
            throw new ArgumentException("Array cannot be null or empty");
    }
    
    public static double CalculateAverage(int[] values) {
        ThrowIfEmpty(values);

        int sum = 0;

        foreach (int v in values) {
            sum += v;
        }

        return (double)sum / values.Length;
    }

    public static int CalculateMax(int[] values) {
        ThrowIfEmpty(values);

        int max = values[0];

        foreach (int v in values) {
            if (v > max)
                max = v;
        }

        return max;
    }

    public static int CalculateMin(int[] values) {
        ThrowIfEmpty(values);

        int min = values[0];

        foreach (int v in values)
        {
            if (v < min)
                min = v;
        }

        return min;
    }
}