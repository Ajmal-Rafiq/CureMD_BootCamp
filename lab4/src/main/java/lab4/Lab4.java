package lab4;

import org.openqa.selenium.By;
//import org.openqa.selenium.By.ByLinkText;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.edge.EdgeDriver;
import org.openqa.selenium.support.ui.ExpectedConditions;
//import org.openqa.selenium.support.ui.FluentWait;
import org.openqa.selenium.support.ui.Select;
import org.openqa.selenium.support.ui.WebDriverWait;
import org.testng.annotations.AfterTest;
import org.testng.annotations.BeforeTest;
import org.testng.annotations.Test;

import java.time.Duration;

public class Lab4 {
	WebDriver driver;
	WebDriverWait wait = new WebDriverWait(driver, Duration.ofSeconds(10)); 
	
	@BeforeTest
    public void setUp() {
		driver = new EdgeDriver();
		driver.manage().window();
		driver.get("https://www.globalsqa.com/angularJs-protractor/BankingProject");
		System.out.println("Website Opened");
	}
	
	
	@Test
	public void test(){
	
		
		WebElement managerLogin = wait.until(ExpectedConditions.elementToBeClickable(By.xpath("//button[text()=\"Bank Manager Login\"]")));
		managerLogin.click();
		System.out.println("Manager Login Clicked");	
	}
	@Test
	public void test1(){
		
		WebElement addCustomer = wait.until(ExpectedConditions.elementToBeClickable(By.xpath("//button[contains(text(),'Add Customer') and @ng-class=\"btnClass1\"]")));
		addCustomer.click();
		System.out.println("Add Customer Clicked");
		
		
	
	}
	@Test
	public void test2() {
		
		
		WebElement firstName = wait.until(ExpectedConditions.elementToBeClickable(By.xpath("//label[contains(text(),'First Name')]/following-sibling::input")));
		//WebElement firstName = driver.findElement(By.xpath(""));
		firstName.sendKeys("Liam");
		System.out.println("First Name Added");
		
		WebElement lastName = driver.findElement(By.xpath("//label[contains(text(),'Last Name')]/following-sibling::input"));
		lastName.sendKeys("Walker");
		System.out.println("Last Name Added");

		WebElement postCode = driver.findElement(By.xpath("//label[contains(text(),'Post Code')]/following-sibling::input"));
		postCode.sendKeys("E4831");
		System.out.println("Post Code Added");
		
		WebElement addcustomer =  driver.findElement(By.xpath("//button[@type = 'submit']"));
		addcustomer.click();
		System.out.println("Customer Added!");
		
		driver.switchTo().alert().accept();
	}
	
	@Test
	public void test3 () {
		
		
		WebElement openAccount = wait.until(ExpectedConditions.elementToBeClickable(By.xpath("//button[contains(text(),'Open Account')]")));
		openAccount.click();
		
		WebElement customer = wait.until(ExpectedConditions.elementToBeClickable(By.xpath("//select[@name='userSelect']")));
		Select customerName = new Select (customer);
		customerName.selectByVisibleText("Liam Walker");
	
		Select currency = new Select(driver.findElement(By.xpath("//select[@name='currency']")));
		currency.selectByVisibleText("Dollar");
		
		WebElement Process=  driver.findElement(By.xpath("//button[@type='submit']"));
		Process.click();
		System.out.println("Process Clicked");
		
		driver.switchTo().alert().accept();
		
		
	}

	@AfterTest
	public void tearDown() {
       // driver.quit();
    }
		
	
}
