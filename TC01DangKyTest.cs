// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class TC01DangKyTest {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  [Test]
  public void tC01DangKy() {
    driver.Navigate().GoToUrl("https://id.zing.vn/");
    driver.Manage().Window.Size = new System.Drawing.Size(1382, 744);
    Assert.That(driver.FindElement(By.LinkText("Zing ID")).Text, Is.EqualTo("Zing ID"));
    Assert.That(driver.Title, Is.EqualTo("Zing ID - Zing Passport - Tài khoản Zing của VNG"));
    driver.FindElement(By.LinkText("Đăng ký ngay")).Click();
    driver.FindElement(By.Id("regacc_fullname")).Click();
    driver.FindElement(By.CssSelector(".zidbody")).Click();
    driver.FindElement(By.Id("regacc_fullname")).SendKeys("Thao");
    driver.FindElement(By.Id("regacc_account")).Click();
    driver.FindElement(By.Id("regacc_account")).SendKeys("thao093");
    driver.FindElement(By.Id("check_account_valid")).Click();
    driver.FindElement(By.Id("regacc_account")).Click();
    driver.FindElement(By.Id("regacc_account")).SendKeys("thao09345");
    {
      var element = driver.FindElement(By.Id("check_account_valid"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).ClickAndHold().Perform();
    }
    {
      var element = driver.FindElement(By.Id("regacc_account"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Release().Perform();
    }
    driver.FindElement(By.Id("reg_username")).Click();
    {
      var element = driver.FindElement(By.Id("regacc_pwd"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).ClickAndHold().Perform();
    }
    {
      var element = driver.FindElement(By.Id("regacc_pwd_tooltip"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Release().Perform();
    }
    driver.FindElement(By.CssSelector("#regfrm_step1 > .finput:nth-child(6)")).Click();
    driver.FindElement(By.Id("regacc_pwd")).Click();
    driver.FindElement(By.Id("regacc_pwd")).Click();
    {
      var element = driver.FindElement(By.Id("regacc_pwd"));
      Actions builder = new Actions(driver);
      builder.DoubleClick(element).Perform();
    }
    driver.FindElement(By.CssSelector(".zidbody")).Click();
    driver.FindElement(By.Id("regacc_pwd")).SendKeys("HThao12345@@");
    driver.FindElement(By.Id("regacc_re_pwd")).Click();
    driver.FindElement(By.Id("regacc_re_pwd")).SendKeys("HThao12345@@");
    driver.FindElement(By.CssSelector("label:nth-child(3)")).Click();
    driver.FindElement(By.CssSelector(".reg_birthday:nth-child(10) .reg_date")).Click();
    driver.FindElement(By.Id("dob")).Click();
    {
      var dropdown = driver.FindElement(By.Id("dob"));
      dropdown.FindElement(By.XPath("//option[. = '10']")).Click();
    }
    driver.FindElement(By.CssSelector(".reg_birthday:nth-child(10) .reg_month")).Click();
    driver.FindElement(By.Id("mob")).Click();
    {
      var dropdown = driver.FindElement(By.Id("mob"));
      dropdown.FindElement(By.XPath("//option[. = 'Tháng 6']")).Click();
    }
    driver.FindElement(By.Id("yob")).Click();
    {
      var dropdown = driver.FindElement(By.Id("yob"));
      dropdown.FindElement(By.XPath("//option[. = '1997']")).Click();
    }
    driver.FindElement(By.Name("gender")).Click();
    driver.FindElement(By.LinkText("Tiếp tục")).Click();
    driver.FindElement(By.Id("regacc_phone")).Click();
    driver.FindElement(By.Id("regacc_phone")).Click();
    driver.FindElement(By.Id("regacc_phone")).Click();
    driver.FindElement(By.Id("regacc_phone")).Click();
    driver.FindElement(By.Id("regacc_phone")).SendKeys("0384167279");
    driver.FindElement(By.Id("regacc_email")).Click();
    driver.FindElement(By.Id("regacc_email")).SendKeys("thaotran01222");
    driver.FindElement(By.Id("regacc_email")).SendKeys(Keys.Enter);
    driver.FindElement(By.Id("regacc_email")).SendKeys("thaotran01222@gmail.com");
    driver.FindElement(By.Id("regacc_cmnd")).Click();
    driver.FindElement(By.Id("regacc_cmnd")).Click();
    driver.FindElement(By.Id("regacc_cmnd")).Click();
    driver.FindElement(By.Id("regacc_cmnd_date")).Click();
    {
      var dropdown = driver.FindElement(By.Id("regacc_cmnd_date"));
      dropdown.FindElement(By.XPath("//option[. = '10']")).Click();
    }
    driver.FindElement(By.CssSelector(".reg_birthday:nth-child(8) .reg_month")).Click();
    driver.FindElement(By.CssSelector(".reg_birthday:nth-child(8)")).Click();
    driver.FindElement(By.Id("regacc_cmnd_month")).Click();
    {
      var dropdown = driver.FindElement(By.Id("regacc_cmnd_month"));
      dropdown.FindElement(By.XPath("//option[. = 'Tháng 9']")).Click();
    }
    driver.FindElement(By.CssSelector(".reg_birthday:nth-child(8) .reg_year")).Click();
    driver.FindElement(By.CssSelector(".reg_birthday:nth-child(8)")).Click();
    driver.FindElement(By.Id("regacc_cmnd_year")).Click();
    {
      var dropdown = driver.FindElement(By.Id("regacc_cmnd_year"));
      dropdown.FindElement(By.XPath("//option[. = '2010']")).Click();
    }
    driver.FindElement(By.Id("regacc_cmnd_place")).Click();
    {
      var dropdown = driver.FindElement(By.Id("regacc_cmnd_place"));
      dropdown.FindElement(By.XPath("//option[. = 'Cục Cảnh sát quản lý hành chính về trật tự xã hội']")).Click();
    }
    driver.FindElement(By.Id("regacc_address")).Click();
    driver.FindElement(By.CssSelector("h2:nth-child(1)")).Click();
    driver.FindElement(By.Id("regacc_veryfied_code")).Click();
    driver.FindElement(By.Id("regacc_veryfied_code")).SendKeys("NTUETB");
    driver.FindElement(By.Id("checkPolicy18")).Click();
    driver.FindElement(By.Id("regacc_address")).Click();
    driver.FindElement(By.Id("regacc_address")).SendKeys("TP.HCM");
    driver.FindElement(By.Id("regacc_cmnd")).Click();
    driver.FindElement(By.Id("regacc_cmnd")).SendKeys("0793020296");
    driver.FindElement(By.CssSelector(".reg_birthday:nth-child(8)")).Click();
    driver.FindElement(By.LinkText("Đăng ký")).Click();
    driver.SwitchTo().Frame(2);
    driver.SwitchTo().DefaultContent();
    driver.Close();
  }
}
