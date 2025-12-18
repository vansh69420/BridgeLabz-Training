import java.util.*;
public class prime {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt(), flag = 1;
        if (n <= 1) flag = 0;
        for (int i = 2; i <= Math.sqrt(n); i++) {
            if (n % i == 0) {
                flag = 0;
                break;
            }
        }
        System.out.println(flag == 1 ? "Prime" : "Not Prime");
    }
}
