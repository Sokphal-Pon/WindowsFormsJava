
public class hello{

    public static void main(String[] args) {
        System.out.println("=====Hello 56kmt!======");
        if(args.length>=2){
          int a = Integer.parseInt(args[0]);
          int b = Integer.parseInt(args[1]);
          int sum=a+b;
          System.out.println("\n::::::Sum="+sum);
        }else{
          System.out.println("Chua truyen 2 so nguyen, ko tinh dc sum");
        }
        System.exit(0);
    }

}
// Hello World!