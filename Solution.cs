public class Solution
{
    public static int[,] genSpiral(int n)
    {
        int[,] result = new int[n, n];

        var path = new int[n * 2 - 1];

        path[0] = n;
        var i = 1;
        var offset = 1;
        var interval = 2;

        while (i < path.Length)
        {
            if (interval > 0) 
            {
                path[i] = n - offset;
                i++;
                interval--;
            }
            else
            {
                offset++;
                interval = 2;
            }
        }

        i = 0;
        var row = 0;
        var column = 0;
        var isRow = true;
        var number = 1;
        var increase = true;

        while(i < path.Length)
        {
            var totalSteps = path[i];
            var currentStep = 0;

            if (isRow)
            {
                if (increase)
                {
                    while(currentStep < totalSteps)
                    {
                        result[row, column] = number++;
                        currentStep++;
                        column++;
                    }
                    // resets
                    column = totalSteps == n ? n - 1 : column - 1;
                    row++;
                }
                else
                {
                    while(currentStep < totalSteps)
                    {
                        result[row, column] = number++;
                        currentStep++;
                        column--;
                    }
                    // resets
                    column++;
                    row--;
                }
            }
            else
            {
                if (increase)
                {
                    while(currentStep < totalSteps)
                    {
                        result[row, column] = number++;
                        currentStep++;
                        row++;
                    }
                    // resets
                    row = column;
                    column--;
                }
                else
                {
                    while(currentStep < totalSteps)
                    {
                        result[row, column] = number++;
                        currentStep++;
                        row--;
                    }
                    // resets
                    row++;
                    column++;
                }
                increase = !increase;
            }
            i++;
            isRow = !isRow;
        }

        // Debug
        // Console.WriteLine("[{0}]", string.Join(", ", path));\
        return result;
    }
}