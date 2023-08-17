package lab6;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.edge.EdgeDriver;
import org.openqa.selenium.support.ui.ExpectedConditions;
import org.openqa.selenium.support.ui.Select;
import org.openqa.selenium.support.ui.WebDriverWait;
import org.testng.annotations.AfterTest;
import org.testng.annotations.BeforeTest;
import org.testng.annotations.Test;
import java.time.Duration;

public class Lab6 {
	
	WebDriver driver;
	WebDriverWait wait;
	
	@BeforeTest
    public void setUp() {
		driver = new EdgeDriver();
		driver.manage().window();
		driver.get("https://www.globalsqa.com/angularJs-protractor/BankingProject");
		System.out.println("Website Opened");
	
		wait = new WebDriverWait(driver, Duration.ofSeconds(10));
	}	

	@Test(priority = 1)
	public void test(){
	
		
		WebElement managerLogin = wait.until(ExpectedConditions.elementToBeClickable(By.xpath("//button[text()=\"Bank Manager Login\"]")));
		managerLogin.click();
		System.out.println("Manager Login Clicked");	
	}
	@Test(priority = 2)
	public void test1(){
		
		WebElement addCustomer = wait.until(ExpectedConditions.elementToBeClickable(By.xpath("//button[contains(text(),'Add Customer') and  contains(@ng-class,\"btnClass\")]")));
		addCustomer.click();
		System.out.println("Add Customer Clicked");
	}
	@Test(priority = 3)
	public void test2() {
		
		WebElement firstName = wait.until(ExpectedConditions.elementToBeClickable(By.xpath("//label[contains(text(),'First Name')]/following-sibling::input")));
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
	@Test(priority = 4)
	public void test3() {
		WebElement openAccount = wait.until(ExpectedConditions.elementToBeClickable(By.xpath("//button[contains(text(),'Open Account')]")));
		openAccount.click();
		
	}
	@Test(priority = 5)
	public void test4 () {
		WebElement customer = wait.until(ExpectedConditions.elementToBeClickable(By.xpath("//select[@name='userSelect']")));
		Select customerName = new Select (customer);
		customerName.selectByVisibleText("Liam Walker");
	
		Select currency = new Select(driver.findElement(By.xpath("//select[@name='currency']")));
		currency.selectByVisibleText("Dollar");	
	}
	@Test(priority = 6)
	public void test5() {
		WebElement Process=  driver.findElement(By.xpath("//button[@type='submit']"));
		Process.click();
		System.out.println("Process Clicked");
		
		driver.switchTo().alert().accept();
		
	}
	@Test (priority = 7)
	public void test6() {
		
		WebElement home = driver.findElement(By.xpath("//button[text()='Home']"));
		home.click();
		
	}
	@Test(priority = 8)
	public void test7() {
		
		WebElement customerLogin = wait.until(ExpectedConditions.elementToBeClickable(By.xpath("//button[text()='Customer Login']")));
		customerLogin.click();
		System.out.println("Customer Login Clicked.");
		
	}
	@Test (priority = 9)
	public void test8() {
		WebElement customer = wait.until(ExpectedConditions.elementToBeClickable(By.xpath("//select[@name='userSelect']")));
		Select customerName = new Select (customer);
		customerName.selectByVisibleText("Liam Walker");
		System.out.println("Liam Walker selected after customer login");
	}	
	@Test (priority = 10)
	public void test9() {

		WebElement loginButton = wait.until(ExpectedConditions.elementToBeClickable(By.xpath("//button[text()='Login']")));
		loginButton.click();
		System.out.println("Login Button Clicked");
	}
	@Test(priority = 11)
	public void test10()
	{
		//wait = new WebDriverWait(driver, Duration.ofSeconds(20));
		WebElement depositclick= wait.until(ExpectedConditions.elementToBeClickable(By.xpath("//button[contains(@ng-click,'deposit')]")));
		depositclick.click();
		System.out.println("Deposit Clisked");
	}
	@Test(priority = 12)
	public void test11() {
		
	WebElement amountField = wait.until(ExpectedConditions.elementToBeClickable(By.xpath("//input[@ng-model='amount']")));
	amountField.sendKeys("5000"); 
	
	WebElement depositSubmitButton = driver.findElement(By.xpath("//button[@type='submit']"));
    depositSubmitButton.click();
    
     System.out.println("Amount deposited successfully");
    
	}
	@Test(priority = 13)
	public void test12() {
		
		
		WebElement withdraw = wait.until(ExpectedConditions.elementToBeClickable(By.xpath("//button[contains(@ng-click,'withdrawl')]")));
		withdraw.click();
		System.out.println("Withdrawn Clicked");
	}
	@Test(priority = 14)
	public void test13()throws InterruptedException {
		Thread.sleep(1000);
		WebElement amountField = wait.until(ExpectedConditions.elementToBeClickable(By.xpath("//input[@ng-model='amount']")));
		amountField.sendKeys("2000"); 
		
		WebElement withdrawnSubmitButton = wait.until(ExpectedConditions.elementToBeClickable(By.xpath("//button[@type='submit']")));
		//driver.findElement(By.xpath("//button[@type='submit']"));
		withdrawnSubmitButton.click();
	    System.out.println("Amount Withdrawn successfully");	
	}
	@Test(priority = 15)
	public void test14(){
	
		
	}
	@AfterTest
	public void tearDown() {
       // driver.quit();
    }

}
