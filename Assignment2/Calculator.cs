namespace Calculator
{
    public class Calculator
    {
        private bool first_time = true;
        public long Result;
        public string Error = "no_errors";
        public void Process(Parsed expression)
        {
            string invalid = "Invalid expression!";
            string zero = "Division by zero. :(";
            if (first_time)
            {
                this.Result = expression.Arg1;
                first_time = false;
            }
            long b = expression.Arg2;
            switch (expression.Op)
            {
                case "+":
                    this.Result += b;
                    break;
                case "-":
                    this.Result -= b;
                    break;
                case "*":
                    this.Result *= b;
                    break;
                case "/":
                    if (b == 0)
                        this.Error = zero;
                    else
                        this.Result /= b;
                    break;
                default:
                    this.Error = invalid;
                    break;
            }
        }
    }
}