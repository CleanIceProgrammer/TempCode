namespace Program {
    public class Program {
        public static void Main() {
            const int MAXN = 40005;
            long[] arr = new long[MAXN];
            long ans = 2;
            long n = int.Parse(Console.ReadLine() ?? throw new Exception("NULL"));
            if (n == 1) {
                Console.WriteLine(0);
                return;
            }
            for (int i = 2; i <= n; i++) {
                arr[i] = i;
            }
            for (int i = 2; i <= n; i++) {
                if (arr[i] == i) {
                    for (int j = i; j <= n; j += i) {
                        arr[j] = arr[j] / i * (i - 1);
                    }
                }
            }
            n--; // hello
            for (int i = 2; i <= n; i++) {
                ans += arr[i] * 2;
            }
            Console.WriteLine(ans + 1);
        }
    }
}
