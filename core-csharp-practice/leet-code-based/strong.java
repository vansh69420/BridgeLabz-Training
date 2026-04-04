import java.util.*;

public class strong {
    static int fact(int n) {
        int f = 1;
        for (int i = 1; i <= n; i++) f *= i;
        return f;
    }

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt(), temp = n, sum = 0;
        while (n > 0) {
            sum += fact(n % 10);
            n /= 10;
        }
        System.out.println(temp == sum ? "Strong" : "Not Strong");
    }
}
