
import java.util.Locale;
import java.util.Scanner;

public class FLAMES {
	
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		
		System.out.print("Enter the first name: ");
		String a = sc.next().toLowerCase(Locale.ROOT); //converts the input to lower case for easier use
		
		System.out.print("Enter the second name: ");
		String b = sc.next().toLowerCase(Locale.ROOT);

		StringBuilder plus = new StringBuilder(); //a StringBuilder is used because of what happens in line 28
		char[] aa, bb;

		aa = a.toCharArray(); //the names are converted to char arrays so that we can easily work with their letters
		bb = b.toCharArray();

		for (int i = 0; i < a.length(); i++) { //this picks out a single letter from the first name

			for (int j = 0; j < b.length(); j++) { //then it checks each letter of the second name
				if ((aa[i] == bb[j])) {
					/*if the selected letter of the first name is the same as the current letter of the second one,
					it stores that letter and 'deletes' both letters. More like canceling them out*/
					plus.append(aa[i]);
					aa[i] = ' ';
					bb[j] = ' ';
				}
			}
		}

		/*since the .length() method can't be accurately used with a StringBuilder variable
		we'll have to use a naive way to find out it's length*/
		int count = 0;
		String pp = plus.toString();
		char[] p = pp.toCharArray();

		for (int i = 0; i < plus.length(); i++){
			if (p[i] != ' '){
				count++;
			}
		}

		System.out.println();

		//we find out the remaining letters after cancelling out the common corresponding letters from each name
		int length = (a.length() + b.length()) - (count * 2);
		System.out.println("Result: " + length);

		int rem = length % 6; //we find out which letter in "FLAMES" it falls on

		System.out.print("Using the FLAMES analysis, ");

		switch (rem) { //we print out the result
			case 1 -> System.out.println("You two should be just friends");

			case 2 -> System.out.println("You two should be lovers");

			case 3 -> System.out.println("You two should be admirers");

			case 4 -> System.out.println("You two should get married");

			case 5 -> System.out.println("You two should be enemies");

			case 0 -> System.out.println("You two should be secret admirers");

		}
	}
}