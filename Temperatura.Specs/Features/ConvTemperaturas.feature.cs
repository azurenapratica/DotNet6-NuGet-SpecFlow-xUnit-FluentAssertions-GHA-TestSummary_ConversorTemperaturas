﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Temperatura.Specs.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class ConversaoDeTemperaturasEmFahrenheitFeature : object, Xunit.IClassFixture<ConversaoDeTemperaturasEmFahrenheitFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "ConvTemperaturas.feature"
#line hidden
        
        public ConversaoDeTemperaturasEmFahrenheitFeature(ConversaoDeTemperaturasEmFahrenheitFeature.FixtureData fixtureData, Temperatura_Specs_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-BR"), "Features", "Conversao de temperaturas em Fahrenheit", null, ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public void TestInitialize()
        {
        }
        
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="SimulacaoTemperatura01")]
        [Xunit.TraitAttribute("FeatureTitle", "Conversao de temperaturas em Fahrenheit")]
        [Xunit.TraitAttribute("Description", "SimulacaoTemperatura01")]
        public void SimulacaoTemperatura01()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("SimulacaoTemperatura01", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 3
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
 testRunner.Given("que o valor da temperatura e de 32 graus Fahrenheit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line hidden
#line 5
 testRunner.When("eu solicitar a conversao desta teperatura", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line hidden
#line 6
 testRunner.Then("o resultado da conversao para Celsius sera de 0 graus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
#line 7
 testRunner.And("o resultado da conversao para Kelvin sera de 273,15 graus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="SimulacaoTemperatura02")]
        [Xunit.TraitAttribute("FeatureTitle", "Conversao de temperaturas em Fahrenheit")]
        [Xunit.TraitAttribute("Description", "SimulacaoTemperatura02")]
        public void SimulacaoTemperatura02()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("SimulacaoTemperatura02", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 9
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 10
 testRunner.Given("que o valor da temperatura e de 86 graus Fahrenheit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line hidden
#line 11
 testRunner.When("eu solicitar a conversao desta teperatura", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line hidden
#line 12
 testRunner.Then("o resultado da conversao para Celsius sera de 30 graus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
#line 13
 testRunner.And("o resultado da conversao para Kelvin sera de 303,15 graus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="SimulacaoTemperatura03")]
        [Xunit.TraitAttribute("FeatureTitle", "Conversao de temperaturas em Fahrenheit")]
        [Xunit.TraitAttribute("Description", "SimulacaoTemperatura03")]
        public void SimulacaoTemperatura03()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("SimulacaoTemperatura03", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 15
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 16
 testRunner.Given("que o valor da temperatura e de 47 graus Fahrenheit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line hidden
#line 17
 testRunner.When("eu solicitar a conversao desta teperatura", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line hidden
#line 18
 testRunner.Then("o resultado da conversao para Celsius sera de 8,33 graus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
#line 19
 testRunner.And("o resultado da conversao para Kelvin sera de 281,48 graus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="SimulacaoTemperatura04")]
        [Xunit.TraitAttribute("FeatureTitle", "Conversao de temperaturas em Fahrenheit")]
        [Xunit.TraitAttribute("Description", "SimulacaoTemperatura04")]
        public void SimulacaoTemperatura04()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("SimulacaoTemperatura04", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 21
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 22
 testRunner.Given("que o valor da temperatura e de 90,5 graus Fahrenheit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line hidden
#line 23
 testRunner.When("eu solicitar a conversao desta teperatura", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line hidden
#line 24
 testRunner.Then("o resultado da conversao para Celsius sera de 32,5 graus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
#line 25
 testRunner.And("o resultado da conversao para Kelvin sera de 305,65 graus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="SimulacaoTemperatura05")]
        [Xunit.TraitAttribute("FeatureTitle", "Conversao de temperaturas em Fahrenheit")]
        [Xunit.TraitAttribute("Description", "SimulacaoTemperatura05")]
        public void SimulacaoTemperatura05()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("SimulacaoTemperatura05", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 27
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 28
 testRunner.Given("que o valor da temperatura e de 120,18 graus Fahrenheit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line hidden
#line 29
 testRunner.When("eu solicitar a conversao desta teperatura", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line hidden
#line 30
 testRunner.Then("o resultado da conversao para Celsius sera de 48,99 graus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
#line 31
 testRunner.And("o resultado da conversao para Kelvin sera de 322,14 graus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="SimulacaoTemperatura06")]
        [Xunit.TraitAttribute("FeatureTitle", "Conversao de temperaturas em Fahrenheit")]
        [Xunit.TraitAttribute("Description", "SimulacaoTemperatura06")]
        public void SimulacaoTemperatura06()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("SimulacaoTemperatura06", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 33
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 34
 testRunner.Given("que o valor da temperatura e de 212 graus Fahrenheit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line hidden
#line 35
 testRunner.When("eu solicitar a conversao desta teperatura", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line hidden
#line 36
 testRunner.Then("o resultado da conversao para Celsius sera de 100 graus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
#line 37
 testRunner.And("o resultado da conversao para Kelvin sera de 373,15 graus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                ConversaoDeTemperaturasEmFahrenheitFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                ConversaoDeTemperaturasEmFahrenheitFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion