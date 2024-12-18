namespace SolveApp
{
    public class Solution
    {
        public double? X1 { get; set; }
        public double? X2 { get; set; }

        public Solution(double? x1, double? x2)
        {
            X1 = x1;
            X2 = x2;
        }

        public override string ToString()
        {
            return $"X1={X1}, X2={X2}";
        }
    }
}
