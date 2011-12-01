﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.239
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecsAgainstController.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Add new activity")]
    public partial class AddNewActivityFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "AddNewActivity.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Add new activity", "In order to keep track of the activities I do at work\r\nAs a consultant\r\nI want to" +
                    " be able to add a activity I have done", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 6
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Activity id",
                        "When",
                        "Number of hours",
                        "Who",
                        "At Customer",
                        "Heading",
                        "Description"});
            table1.AddRow(new string[] {
                        "1",
                        "2010-02-17",
                        "2",
                        "Marcus",
                        "Alt.Net",
                        "Fluent NH",
                        "Blixttal om Fluent NHibernate"});
            table1.AddRow(new string[] {
                        "2",
                        "2011-01-17",
                        "4",
                        "Marcus",
                        "LF",
                        "Kanban",
                        "En dragning om Kanban"});
            table1.AddRow(new string[] {
                        "3",
                        "2011-02-17",
                        "2",
                        "Anders",
                        "Avega",
                        "BDD",
                        "Beskrev vad BDD är för säljarna"});
#line 7
 testRunner.Given("the following activities in the database", ((string)(null)), table1);
#line 12
  testRunner.And("I am logged in as Marcus");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add new item without any validation errors")]
        [NUnit.Framework.CategoryAttribute("wip")]
        public virtual void AddNewItemWithoutAnyValidationErrors()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add new item without any validation errors", new string[] {
                        "wip"});
#line 15
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 16
 testRunner.When("I navigate to to the Add Activity page");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table2.AddRow(new string[] {
                        "When",
                        "2011-02-17"});
            table2.AddRow(new string[] {
                        "Number of hours",
                        "3"});
            table2.AddRow(new string[] {
                        "Who",
                        "Marcus"});
            table2.AddRow(new string[] {
                        "At Customer",
                        "Progressive .NET"});
            table2.AddRow(new string[] {
                        "Heading",
                        "SpecFlow"});
            table2.AddRow(new string[] {
                        "Description",
                        "En dragning kring SpecFlow"});
#line 17
  testRunner.And("I submit an activitiy with this information", ((string)(null)), table2);
#line 25
 testRunner.Then("I should be redirected the Activity list");
#line 26
 testRunner.When("I am redirected to the Activity list");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "When",
                        "NumberOfHours",
                        "Heading",
                        "Description"});
            table3.AddRow(new string[] {
                        "2010-02-17",
                        "2",
                        "Fluent NH",
                        "Blixttal om Fluent NHibernate"});
            table3.AddRow(new string[] {
                        "2011-01-17",
                        "4",
                        "Kanban",
                        "En dragning om Kanban"});
            table3.AddRow(new string[] {
                        "2011-02-17",
                        "3",
                        "SpecFlow",
                        "En dragning kring SpecFlow"});
#line 27
 testRunner.Then("I should see the following activites", ((string)(null)), table3);
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
