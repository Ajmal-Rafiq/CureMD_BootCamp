package lab2;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
//import org.openqa.selenium.edge.EdgeDriver;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.WebElement;

public class LAB2 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		WebDriver driver = new ChromeDriver();
		driver.get("https://omayo.blogspot.in/");
		//driver.findElement(By.id("ta1")).sendKeys("Pasha");
		
		
		WebElement textarea = driver.findElement(By.xpath("//*[@id=\"HTML11\"]/div[1]/textarea"));
		String currentValue = textarea.getAttribute("value");
        System.out.println("Current value of textarea: " + currentValue);
		textarea.clear();
		textarea.sendKeys("Mei tu Abhe jawan ho");
		
		WebElement userNameTextarea = driver.findElement(By.xpath("//*[@id=\"HTML31\"]/div[1]/form/input[1]"));
		userNameTextarea.sendKeys("pasha.21");
		
		WebElement passwordTextarea = driver.findElement(By.xpath("//*[@id=\"HTML31\"]/div[1]/form/input[2]"));
		passwordTextarea.sendKeys("%jadoo*");
		
		WebElement loginButton =driver.findElement(By.xpath("//button[@type='LogIn']"));
		if(loginButton != null) {
			System.out.println("Button Pressed");
			
		}
		
		
	}

}
