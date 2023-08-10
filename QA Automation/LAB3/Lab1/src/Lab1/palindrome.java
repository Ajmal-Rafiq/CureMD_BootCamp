package Lab1;



public class palindrome {

	 public static boolean isPalindrome(String str, int start, int end) {
	        while (start < end) {
	            if (str.charAt(start) != str.charAt(end)) {
	                return false;
	            }
	            start++;
	            end--;
	        }
	        return true;
	    }

	    public static String findLongestPalindrome(String str) {
	        if (str == null || str.isEmpty()) {
	            return "";
	        }

	        int maxLength = 1;
	        int start = 0;

	        for (int i = 0; i < str.length(); i++) {
	            for (int j = i + 1; j < str.length(); j++) {
	                if (isPalindrome(str, i, j)) {
	                    if (j - i + 1 > maxLength) {
	                        maxLength = j - i + 1;
	                        start = i;
	                    }
	                }
	            }
	        }

	        return str.substring(start, start + maxLength);
	    }

	    public static void main(String[] args) {
	        String input = "babad";
	        String longestPalindrome = findLongestPalindrome(input);

	        System.out.println("Longest Palindrome: " + longestPalindrome);
	    }

}
