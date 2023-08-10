package lab3;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.edge.EdgeDriver;
import org.openqa.selenium.WebElement;

public class Lab3 {
	public static void main(String[] args)
	{
		WebDriver driver = new EdgeDriver();
		driver.get("https://omayo.blogspot.in/");
		
		WebElement textarea =  driver.findElement(By.xpath("//textarea[contains(@id,'ta')]"));
		textarea.sendKeys("Pasha");
		String readValue = textarea.getAttribute("value");
		if (readValue.equals("\nPasha"))
			System.out.println("Correct Value");
		else
			System.out.println("Incorrect Value");

		
		WebElement table =  driver.findElement(By.xpath("//table[contains(@id,'table')]"));
		String tableContent = table.getText();
		System.out.println(tableContent);
		
		WebElement userNameTextarea = driver.findElement(By.xpath("//form[contains(@name,'form')]//input[@type='text']"));
		userNameTextarea.sendKeys("pasha.21");
		String userName = userNameTextarea.getAttribute("value"); 
		if (userName.equals("pasha.21"))
			System.out.println("Correct username");
		else
			System.out.println("Incorrect username");

	}	
}
