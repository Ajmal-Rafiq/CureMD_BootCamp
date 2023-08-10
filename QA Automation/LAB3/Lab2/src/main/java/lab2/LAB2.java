package lab2;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
//import org.openqa.selenium.edge.EdgeDriver;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.WebElement;

public class LAB2 {

	public static void main(String[] args) {
		WebDriver driver = new ChromeDriver();
		driver.get("https://omayo.blogspot.in/");
		
		driver.findElement(By.xpath("//div[@id='HTML2']//textarea")).sendKeys("Pasha");
		
		
		WebElement textarea = driver.findElement(By.xpath("//div[@id='HTML11']//textarea"));
		String currentValue = textarea.getAttribute("value");
        System.out.println("Current value of textarea: " + currentValue);
		textarea.clear();
		textarea.sendKeys("Donot expect a fish to climb a tree and an elephant to fly. Everyone of is made different.");
		
		WebElement userNameTextarea = driver.findElement(By.xpath("//input[@type='text']"));
		userNameTextarea.sendKeys("pasha.21");
		
		WebElement passwordTextarea = driver.findElement(By.xpath("//input[@type='password']"));
		passwordTextarea.sendKeys("%jadoo*");
		
		WebElement loginButton =driver.findElement(By.xpath("//button[@type='button']"));
		loginButton.click();
		
		
		driver.switchTo().frame("iframe1");
		driver.switchTo().defaultContent();
		driver.switchTo().frame("iframe2");
		driver.switchTo().defaultContent();
		
		driver.findElement(By.xpath("//input[@name='userid']")).sendKeys("pasha.21");
	
		
		WebElement passwordTextarea1 = driver.findElement(By.xpath("//input[@name='pswrd']"));
		passwordTextarea1.sendKeys("%jadooooo*");
		
		WebElement loginButton1 =driver.findElement(By.xpath("//form[@name='login']//input[@value='Login']"));
		loginButton1.click();
		
		driver.switchTo().alert().accept();
		driver.quit();
		
		
	}
}
