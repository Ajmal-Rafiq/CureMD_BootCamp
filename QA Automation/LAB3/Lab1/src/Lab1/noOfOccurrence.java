package Lab1;

import java.util.Scanner;

public class noOfOccurrence {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner scanner = new Scanner(System.in);

	    System.out.print("Enter Word: ");
		String input =scanner.nextLine();
		
		char[] uniqueChar= new char[input.length()];
		int[] frequency = new int[input.length()];
		
		int count =0;
		
		char[] Chars = new char[input.length()];
		
		for (int i =0;i<input.length();i++) {
			
			Chars[i] = input.charAt(i); 
			
		}
		
		 for ( char Char:Chars)
		 {
		
			 boolean found = false;
			 for (int j=0; j<count;j++ )
			 {
			 
				 if(uniqueChar[j]==Char)
				 {
				 
				 frequency[j]++;
				 found =true;
				 break;
				 }
			 }
			 
			 if(!found) 
			 {
				 uniqueChar[count]= Char;
				 frequency [count]= 1;
				 count++;
			 }

		 }
		 
		 int maxfreq =0;
		 for (int i = 0; i < count; i++)
         {
			 if(frequency[i]>maxfreq) {
				 maxfreq=i;
			 }
		
         }
		 
		 
		 for (int i = 0; i < count; i++)
         {
			 
			 System.out.println(uniqueChar[i]+": "+ frequency[i]);
            //Console.WriteLine($"{uniqueWords[i]}: {frequencies[i]}");
			 
         }
		 System.out.println("Max frequency word is-> "+uniqueChar[maxfreq]+": "+ frequency[maxfreq]); 
		 scanner.close();
		
	}

}
