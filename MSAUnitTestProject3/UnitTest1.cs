


            using System;
            using System.Threading;
            using Microsoft.VisualStudio.TestTools.UnitTesting;
            using OpenQA.Selenium;
            using OpenQA.Selenium.Chrome;
            using OpenQA.Selenium.Interactions;
            using OpenQA.Selenium.Support.UI;
            using Protractor;
            using SeleniumExtras.WaitHelpers;
            using System.Collections;
            using ExpectedConditions = OpenQA.Selenium.Support.UI.ExpectedConditions;
            using System.IO;
            using OpenQA.Selenium.Firefox;
            using System.Linq;
            using System.Collections.Generic;
            using OpenQA.Selenium.Support.Events;
//org.openqa.selenium.support.ui.Select;
using OpenQA.Selenium.Interactions;



namespace MSAProject
{

    [TestClass]

    public class UnitTest1
    {
        public IWebDriver ngDriver;
        public NgWebDriver ngWebDriver;
        //public NgWebDriver ngDriver;

        private WebDriverWait waitTime;
        private string URL = "https://g360liteuat2.msa.com/";


        [TestInitialize]
        public void Start()
        {

            ngDriver = new ChromeDriver("F://Java-Selenium Jars");
            ngDriver.Manage().Window.Maximize();


            //  driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));


            waitTime = new WebDriverWait(ngDriver, TimeSpan.FromSeconds(5));

            ngWebDriver = new NgWebDriver(ngDriver);
            // ngWebDriver.WaitForAngular();
        }


        [TestMethod]
        public void TestMethod1()
        {

            ngDriver.Navigate().GoToUrl(URL);

            ngDriver.Manage().Window.Maximize();
            // Thread.Sleep(4000);

            IWebElement msaLogin = waitTime.Until(OpenQA.Selenium.Support.UI.ExpectedConditions.ElementExists(By.XPath("//button[text()='Login with Microsoft']")));

            msaLogin.Submit();

            ngWebDriver.IgnoreSynchronization = true;
            ngWebDriver.WaitForAngular();

            // Thread.Sleep(4000);
            Console.WriteLine("Application Started");

            // NgWebElement email = ngDriver.FindElement(By.XPath("//input[@type='email']"));
            IWebElement SearchResult = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//input[@type='email']")));
            SearchResult.SendKeys("GGodugula@msaservicesinc.com");



            Console.WriteLine("Email entered");


            IWebElement Next = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//input[@type='submit']")));
            Next.Click();
            Thread.Sleep(5000);

            IWebElement password = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//input[@name='passwd']")));
            password.SendKeys("Sree@781");
            //WebDriverWait wait = new WebDriverWait(webdriver, 20);

            Thread.Sleep(5000);
            Console.WriteLine("Password entered");


            IWebElement signIn = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//input[@type='submit']")));
            //fluentWait.signIn = "Element to be searched not found";
            signIn.Click();

            Thread.Sleep(5000);
            Console.WriteLine("Sign-In button clicked");

            IWebElement checkbox = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//input[@type='checkbox']")));
            checkbox.Click();
            Thread.Sleep(3000);
            Console.WriteLine("Checkbox is checked");

            IWebElement yesButton = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//input[@type='submit']")));
            yesButton.Click();
            Thread.Sleep(10000);
            Console.WriteLine("Yes button is clicked");
            Thread.Sleep(5000);





            /*
                        IWebElement brdExport = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//*[@title='BRD Export']")));
                        brdExport.Click();

                        Console.WriteLine("BRD Export is clicked");
                        selectChain(" AVENDRA LLC ");

                    }
                    public void selectChain(String chain) {

                       IWebElement dropdown = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//div[@class='mat-select-arrow']")));

                       dropdown.Click();
                       Console.WriteLine("The dropdown button is clicked");


                        //  SelectElement oSelect = new SelectElement(driver.FindElement(By.XPath("//div[@class='mat-select-arrow']")));

                        IWebElement option = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//span[text()='"+ chain +"']")));

                        option.Click();

                        Console.WriteLine("The option of dropdown is selected.");


                        IWebElement background = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//div[@class='cdk-overlay-backdrop cdk-overlay-transparent-backdrop cdk-overlay-backdrop-showing']")));

                        background.Click();
                        Console.WriteLine("The background is clicked");



                    }

            

*/

            //calenderDate("20","26");



            IWebElement rep = waitTime.Until(ExpectedConditions.ElementExists(By.CssSelector("a[routerlink='reports']")));

            rep.Click();
            Thread.Sleep(6000);

            Console.WriteLine("Reports clicked");
            //   vendorPerformance();
            // marketBenchmark();

            //  vendorPerformance();
            drilldown();


            //Performance(" Product Performance ");

        }


        /*
      public void vendorPerformance()
    {
        IWebElement vendorPerformance = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//a[text()=' Vendor Performance ']")));
        vendorPerformance.Click();
        Console.WriteLine("Vendor Performance is clicked");

            Thread.Sleep(3000);



            //   int totalCount = ngDriver.FindElements(By.XPath("//*[@class='highcharts-point']")).Count;
            //   Console.WriteLine("The total count of vendor performance is " + totalCount);





            Actions action = new Actions(driver);

            IWebElement Vendor1 = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//*[contains(@class,'highcharts-point')][1]"))); 
            action.MoveToElement(Vendor1).Perform();
            Thread.Sleep(2000);



            String gr1 = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//*[contains(@class,'highcharts-label highcharts-tooltip highcharts-color-undefined')]"))).Text;
            Console.WriteLine(ngDriver.FindElement(By.XPath("//*[contains(@class,'highcharts-label highcharts-tooltip highcharts-color-undefined')]")).Text);




        }
*/


        /*                
        public void marketBenchmark()
        {
            // WebDriverWait wait = new WebDriverWait(ngDriver, TimeSpan.FromSeconds(10));
            IWebElement marketBenchmark = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//a[text()=' Market Benchmark ']")));
            marketBenchmark.Click();
            Console.WriteLine("Market Benchmark is clicked");

            Thread.Sleep(4000);

            Console.WriteLine("Market Benchmark List");
          
            var products = driver.FindElements(By.XPath("//*[@class='highcharts-axis-labels highcharts-xaxis-labels']//*[@text-anchor='middle']"));
            int prodCount = products.Count;

            Thread.Sleep(2000);
            for (int i = 0; i < prodCount; i++)
            {
                String Text = driver.FindElements(By.XPath("//*[@class='highcharts-axis-labels highcharts-xaxis-labels']//*[@text-anchor='middle']"))[i].Text;
                // Console.WriteLine("The product text is" + Text);
                String data1text = driver.FindElements(By.XPath("//*[@class='highcharts-label highcharts-data-label highcharts-data-label-color-0']"))[i].Text;

              
            Dictionary<String, String> AuthorList = new Dictionary<String, String>();
                AuthorList.Add(Text, data1text);




                // Read all data    
              
                foreach (KeyValuePair<String, String> author in AuthorList)
                {
                    Console.WriteLine("Product: {0}, Value: {1}", author.Key, author.Value);
                }



                // while (j <= data1Count); 



            }

 */


        public void drilldown()
        {

            IWebElement marketBenchmark = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//a[text()='  Market Benchmark ']")));
            marketBenchmark.Click();

            Console.WriteLine("Market Benchmark is clicked");
            Thread.Sleep(4000);

            int Count = ngDriver.FindElements(By.XPath("//*[contains(@class,'igx-grid__tree-grouping-indicator ng-star-inserted')]")).Count;
            Console.WriteLine("The total number of count is " + Count);

            Console.WriteLine("TOtal Cells: " + ngDriver.FindElements(By.XPath("//*[contains(@class,'igx-grid__tree-grouping-indicator ng-star-inserted')]")).Count);

            IReadOnlyCollection<IWebElement> TableRows = ngDriver.FindElements(By.XPath("//*[contains(@class,'igx-grid__tree-grouping-indicator ng-star-inserted')]")).ToList();

            Console.WriteLine("The total number of table rows is" + TableRows.Count);
            for (int i = 0; i <= TableRows.Count; i++)
            {

                TableRows.ElementAt(i).Click();


            }

                 IWebElement ele = ngDriver.FindElement(By.XPath("//*[contains(text(),'MARLBORO RED KG BX 10 CT')]"));
                    ele.Click();   



                }
           
     




           

            }


        }




    






        /*
         IReadOnlyCollection<IWebElement> TableRows = ngDriver.FindElements(By.XPath("//*[contains(@class,'igx-grid__tree-grouping-indicator ng-star-inserted')]"));

       Console.WriteLine("The total number of table rows is" + TableRows.Count);

       for (int i = 0; i < TableRows.Count; i++)
       {

           TableRows.ElementAt(i).Click();

        }


       Console.WriteLine("Products drilldown is clicked");

*/










        
           
                        
    /*

            foreach (NgWebElement e in ngDriver.FindElements(By.XPath("//*[contains(@class,'igx-grid__td igx-grid__td--fw')]")))
            {
                if (e.Text.Contains("chevron_right") == false)
                {
                    Console.WriteLine(e.Text);
                    e.Click();
                }


            }

    */



// Console.WriteLine("TOtal Cells: " + ngDriver.FindElements(By.XPath("//*[contains(@class,'igx-grid__td igx-grid__td--fw')]")).Count);










/*
    public void Performance(string rep)
    {


        IWebElement productPerformance = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//td[@role='gridcell']/a[text()='" + rep + "']")));
        productPerformance.Click();
        Console.WriteLine("Product Performance is clicked");



        Actions actions = new Actions(driver);

        WebDriverWait wait = new WebDriverWait(ngDriver, TimeSpan.FromSeconds(10));
        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath("//*[contains(@class,'highcharts-point')]")));


    Thread.Sleep(10000);

        var items = new List<string>();



        ///Get highchart Data************************************************************
        int total = ngDriver.FindElements(By.XPath("//*[contains(@class,'highcharts-point')]")).Count;
        Console.WriteLine(ngDriver.FindElements(By.XPath("//*[contains(@class,'highcharts-point')]")).Count);
        for (int i = 0; i < total; i++)
        {
            actions.MoveToElement(ngDriver.FindElements(By.XPath("//*[contains(@class,'highcharts-point')]"))[i]).Perform();
            Thread.Sleep(2000);
            int test = ngDriver.FindElements(By.XPath("//*[contains(@class,'highcharts-label highcharts-tooltip highcharts-color-undefined')]")).Count;
            for (int j = 0; j < test; j++)
            {
                Console.WriteLine(ngDriver.FindElements(By.XPath("//*[contains(@class,'highcharts-label highcharts-tooltip highcharts-color-undefined')]"))[j].Text);

                IWebElement perf = ngDriver.FindElements(By.XPath("//*[contains(@class,'highcharts-label highcharts-tooltip highcharts-color-undefined')]"))[j];

                String perfText = perf.Text;
                Console.WriteLine("The value of product performance is" + perfText);

            }
            //Console.WriteLine(ngDriver.FindElement(By.XPath("//*[contains(@class,'highcharts-label highcharts-tooltip highcharts-color-undefined')][2]")).Text);
            Thread.Sleep(1000);

*/









/*
            var items = new List<string>();
            WebDriverWait wait = new WebDriverWait(ngDriver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath("//*[contains(@class,'highcharts-point')]")));

            ///Get highchart Data************************************************************
            int total = ngDriver.FindElements(By.XPath("//*[contains(@class,'highcharts-point')]")).Count;
            Console.WriteLine(ngDriver.FindElements(By.XPath("//*[contains(@class,'highcharts-point')]")).Count);
            for (int i = 0; i < total; i++)
            {
                action.MoveToElement(ngDriver.FindElements(By.XPath("//*[contains(@class,'highcharts-point')]"))[i]).Perform();
                Thread.Sleep(2000);
                int test = ngDriver.FindElements(By.XPath("//*[contains(@class,'highcharts-label highcharts-tooltip highcharts-color-undefined')]")).Count;
                for (int j = 0; j < test; j++)
                {
                    String text = ngDriver.FindElements(By.XPath("//*[contains(@class,'highcharts-label highcharts-tooltip highcharts-color-undefined')]"))[j].Text;
                    text = text.Replace("\n", "");
                    text = text.Replace(",", "");
                    Console.WriteLine(text);
                    if (text.Trim() != "")
                    {
                        items.Add(text.Trim().ToUpper());
                    }
                }
                Thread.Sleep(1000);
            }


*/

















/*
IWebElement avgCountPerStore = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//*[contains(text(),' Avg. Item Count Per Store ')]")));
avgCountPerStore.Click();
Thread.Sleep(6000);
Console.WriteLine("avgCountPerStore Clicked");

IWebElement lastPeriod = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//*[@style='font-family: var(--font-stack);fill:var(--body-text);cursor:pointer;font-size:11px;font-weight:900;fill:var(--body-text);padding-left:2px;']")));
//IWebElement thisPeriod1 = thisPeriod.FindElement(By.XPath("[@xpath='2']"));
String lastPeriodText = lastPeriod.Text;
Thread.Sleep(3000);
Console.WriteLine("The lastPeriod value is" + lastPeriodText);

IWebElement thisPeriod = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//*[@x='12' and @y='19']//*[@style='font-family: var(--font-stack);fill:#A0A0A0;cursor:pointer;font-size:11px;font-weight:900;fill:var(--body-text);']")));

String thisPeriodText = thisPeriod.Text;
Thread.Sleep(3000);

Console.WriteLine("The ThisPeriod value is" + thisPeriodText);

IWebElement difference = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//span[@class='highcharts-title']")));
String differenceText = difference.Text;
Console.WriteLine("The value of difference is "+ differenceText);


IWebElement topHeader = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//span[@title='Avg. Item Count Per Store']")));

String topHeaderText = topHeader.Text;

IWebElement titleTooltip = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//span[@mattooltipclass='mat-tooltip-right']")));

String titleTooltipText = titleTooltip.Text;

if(topHeaderText == titleTooltipText)
{
    Console.WriteLine("Both the topheader title and the title tooltip are same");

}



*/







/*


            //Avg Sales Per items per Week

            IWebElement avgSalesPerItemsPerWeek = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//*[contains(text(),' Avg. Sales Per Item Per Week ')]")));
            avgSalesPerItemsPerWeek.Click();
            Thread.Sleep(6000);
            Console.WriteLine("avgSalesPerItemsPerWeek clicked");



            IWebElement Distributer = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//*[@style='font-family: var(--font-stack);fill:#A0A0A0;cursor:pointer;font-size:11px;font-weight:900;fill:var(--body-text);padding-left:5px']")));
            String DistributerText = Distributer.Text;
            Console.WriteLine("The value of difference is " + DistributerText);


            IWebElement Market = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//*[@style='font-family: var(--font-stack);fill:#A0A0A0;cursor:pointer;font-size:11px;font-weight:900;fill:var(--body-text);']")));

            String MarketText = Market.Text;

            Console.WriteLine("The value of difference is " + MarketText);

            IWebElement SalesDifference = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//span[@class='highcharts-title']")));
            String SalesDifferenceText = SalesDifference.Text;



            Console.WriteLine("The value of difference is " + SalesDifferenceText);

            IWebElement topHeader1 = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//span[@class='breadcrumb-heading ng-star-inserted']")));
            String topHeaderText = topHeader1.Text;

            IWebElement titleToolTip1 = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//span[@mattooltipclass='mat-tooltip-right']")));
            String titleToolTip1Text = titleToolTip1.Text;

            if(topHeaderText == titleToolTip1Text)
            {
                Console.WriteLine("Both topHeaderText and titleToolTip1Text are the same ");
            }
            */



/*

                //AvgSalesPerStorePerWeek

                IWebElement avgSalesPerStoresPerWeek = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//*[contains(text(),' Avg. Sales Per Store Per Week ')]")));
            avgSalesPerStoresPerWeek.Click();
            Thread.Sleep(6000);
            Console.WriteLine("Average sales per stores per week is clicked");





            IWebElement MarketValue = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//*[@style='color:#A0A0A0;cursor:pointer;font-size:10px;font-weight:bold;fill:#A0A0A0;']//*[@style='font-family: var(--font-stack);fill:#A0A0A0;cursor:pointer;font-size:11px;font-weight:900;fill:var(--body-text);']")));
            String MarketValueText = MarketValue.Text;

            Console.WriteLine("The value of MarketValueText is " + MarketValueText);

            IWebElement DistributerValue = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//*[@class='highcharts-legend-item highcharts-pie-series highcharts-color-1 highcharts-legend-item-hidden' and @data-z-index='1']//*[@style='color:#cccccc;cursor:pointer;font-size:10px;font-weight:bold;fill:#cccccc;']//*[@style='font-family: var(--font-stack);fill:#A0A0A0;cursor:pointer;font-size:11px;font-weight:900;fill:var(--body-text);']")));
            String DistributerValueText = DistributerValue.Text;

            Console.WriteLine("The DistributerValue is" + DistributerValueText);


            IWebElement differenceperWeek = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//span[@class='highcharts-title']")));
            String differenceperWeekText = differenceperWeek.Text;
            Console.WriteLine("The differenceperWeek is" + differenceperWeekText);


            int count = ngDriver.FindElements(By.XPath("//*[contains(@class,'highcharts-point')]")).Count;











            //*[@style='color:#A0A0A0;cursor:pointer;font-size:10px;font-weight:bold;fill:#A0A0A0;']//*[@style='font-family: var(--font-stack);fill:#A0A0A0;cursor:pointer;font-size:11px;font-weight:900;fill:var(--body-text);']
            //Scheduler();
            // Export("Export to Excel");



            /*   
               IWebElement addFilters = waitTime.Until(ExpectedConditions.ElementExists(By.CssSelector("button[title='Add Filters']")));
               addFilters.Click();
               Thread.Sleep(6000);
               Console.WriteLine("AddFilters is Clicked");

               //addFilters12();


            IWebElement addColumn = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//button[@title='Add Column']")));
            addColumn.Click();
            Thread.Sleep(6000);
            Console.WriteLine("AddColumn1 is Clicked");



//   dateRange(" Last 13 week ");


// addFilters12("category", "Cigarettes");
// addFilters12("sub-category", "Premium");
//AddColumn1("% Dist Sales");
//alertMessage("Add column Preferences Saved");
//   dateRange("Last 13 week");



/*

public void addFilters12(String Filter, String Value)
{
    var Select = waitTime.Until(ExpectedConditions.ElementExists(By.CssSelector("select[ng-reflect-model='Select']")));

    var selectElement = new SelectElement(Select);



    selectElement.SelectByValue(Filter);
    Thread.Sleep(3000);
    Console.WriteLine("Select a particular option");

    var fieldChkBox = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//label[text()='" + Value + "']/../span")));
    fieldChkBox.Click();

    Console.WriteLine("Select a particular field");


  //  VerifyaddFiltersText(Filter, Value);
    var applyBtn = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//button[text()='Apply']")));
    applyBtn.Click();

    Console.WriteLine("Apply button is clicked");

    VerifyaddFiltersText(Filter, Value);

}

public void VerifyaddFiltersText(String Filter, String Value)
{
    String givenInput = Filter + ": " + Value;
    Console.WriteLine(givenInput);
    var addFilterText = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//span[@class='cursor-pointer ng-star-inserted']")));



    String addFilterText1 = addFilterText.Text;
    Console.WriteLine("The added filter is " + addFilterText1);

    if (String.Compare(givenInput, addFilterText1) == 0)
        Console.WriteLine($"Both strings have same value.");

    var homeScreenInput = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//span[@class='cursor-pointer ng-star-inserted']/../span")));
    String homeScreenInputText = homeScreenInput.Text;

    Console.WriteLine("The given input filter text is " + homeScreenInputText);

    if(addFilterText1 == homeScreenInputText)
    {
        Console.WriteLine("Both addedfiter text and homescreenfilter texts are same");
    }




}

*/

/*

    public void AddColumn1(String clmTxt)
    {


        var addClmCheck = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//label[text()='" + clmTxt + "']/../span")));
        addClmCheck.Click();
        Thread.Sleep(3000);
        String givenInput = clmTxt;
        Console.WriteLine("The given text input is" + clmTxt);
        Console.WriteLine("Column was clicked");
        VerifyAddedBadge("Count of SKUs Yago");
    }

    public void VerifyAddedBadge(String clmTxt1) {

        var addClmCheck = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//label[text()='Count of SKUs Yago']/../span")));
        String addClmCheckText =  addClmCheck.Text;


        var Element = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//div[@class='colum-order-badge ng-star-inserted' and text()=' Count of SKUs Yago ']")));


        IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
        js.ExecuteScript("arguments[0].scrollIntoView();", Element);
        //label[text()='" + Value + "']/../span"
        Thread.Sleep(7000);
        var colAddedBadge = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//div[@class='colum-order-badge ng-star-inserted' and text()=' Count of SKUs Yago ']")));
    //    colAddedBadge.Click();
        Console.WriteLine("The column badge is clicked");

        String addedBadge = colAddedBadge.Text;
        Console.WriteLine("The added column badge is" + addedBadge);

            if(addClmCheckText == addedBadge)
        {
            Console.WriteLine("The added column matches");
        }


            var applyBtn = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//button[text()='Apply']")));
            applyBtn.Click();

            Console.WriteLine("Apply button was clicked");


        }

    */
/*
                public void dateRange(String daterange)
                {
                    var dateRangeIcon = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//span[@class='ca-filter-icon icon-calendar-filter']")));
                    dateRangeIcon.Click();

                    var Last13Weeks = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//span[text()='" + daterange + "' and  @class='highlight']")));


                    Last13Weeks.Click();



                }


            /*
                public void Export(String Option)
                {

                    var Export = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//span[@class='icon-export icon']")));
                    Export.Click();
                    Thread.Sleep(4000);
                    Console.WriteLine("Export button is clicked");

                    var excelExport = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//div//*[contains(text(),'" + Option + "')]")));
                    excelExport.Click();
                    Console.WriteLine("The excel document is exported");

                  //  if (waitTime.Until(ExpectedConditions.AlertIsPresent()) == null)
                 //   {

                   //     Console.WriteLine("Alert not displayed");
                //    }





                }









         /*    
        public void Scheduler()
        {

            var Scheduler = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//span[text()='Scheduler']")));
            Scheduler.Click();

            Console.WriteLine("Scheduler is clicked");

            var scheduleTitle = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//input[@placeholder='Title of the scheduler']")));

            scheduleTitle.SendKeys("First Schedule");
            Console.WriteLine("Given the scheduler input");

            var reportFormat = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//select[@formcontrolname='exportFormat']")));
            SelectElement oSelect = new SelectElement(reportFormat);

            oSelect.SelectByValue("PPT");
            Console.WriteLine("Selected a dropdown value");

            var srchFrequency = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//select[@formcontrolname='selectedSchedule']")));
            SelectElement srcFrequency = new SelectElement(srchFrequency);

            srcFrequency.SelectByText("Weekly");
            Console.WriteLine("The searchfrequency is selected");

            //var runTime = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//input[@ng-reflect-placeholder='hh:mm tt']")));
            // runTime.SendKeys("12:17 PM");
            // Console.WriteLine("The runtime input is given");

            var saveButton = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//button[text()='Save' and @class='btn btn-primary btn-lg']")));
            saveButton.Click();
        }
        */
/*
  public void alertMessage(String alertMsgText1) { 
    String originalMessage = "Add column Preferences Saved";
    //var alert_win = driver.SwitchTo().Alert();
    var alertMsg = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//div[@id='toast-container']")));
    String alertMsgText = alertMsg.Text;





    if (originalMessage == alertMsgText1)
    {
        Console.WriteLine("The original message is matching with alert message");



    }
}
}
}

*/
/*
public void dateRange(String daterange)
  {
      var dateRangeIcon = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//span[@class='ca-filter-icon icon-calendar-filter']")));
      dateRangeIcon.Click();

      var Last13Weeks = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//span[text()='" + daterange + "' and  @class='highlight']")));


      Last13Weeks.Click();



  }



*/






/*
        public void calenderDate(String date1,String date2)
        {
            var calenderLink = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//div[@name='calendar']")));
            calenderLink.Click();
            Console.WriteLine("The calender icon is clicked");

            var startDate = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//td[@ng-reflect-klass='mat-calendar-body-cell']//div[contains(text(),'" + date1 + "')]")));
            startDate.Click();
            Console.WriteLine("The particular startdate is picked");

            var endDate = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//td[@ng-reflect-klass='mat-calendar-body-cell']//div[contains(text(),'" + date2 + "')]")));
            endDate.Click();
            Console.WriteLine("The particular enddate is picked");


        }
    }




}
















  //var StoresSelling = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//div[@ng-reflect-name='1']//label//label[text()='# Stores Selling']//preceding::span[@class='checkmark'][1]")));

// StoresSelling.Click();


//var Sales = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//div[@ng-reflect-name='0']/div//label[@class='checkbox-container ng-star-inserted'][4]")));
//Sales.Click();




//      var StoresSelling12 = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//div[@ng-reflect-name='1']/div//label[@class='checkbox-container ng-star-inserted'][5]")));
//       StoresSelling12.Click();

//     var Units = waitTime.Until(ExpectedConditions.ElementExists(By.XPath("//div[@ng-reflect-name='2']/div//label[@class='checkbox-container ng-star-inserted'][6]")));
//  Units.Click();























    */




