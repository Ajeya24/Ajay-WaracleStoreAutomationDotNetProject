using Microsoft.Playwright;
using Reqnroll.BoDi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reqnroll;
using WaracleProject.Driver;

namespace WaracleStoreProject
{
    [Binding]
    public class Hooks
    {
        private readonly IObjectContainer objectContainer;
        private readonly ScenarioContext scenarioContext;
        private BrowserProvider? browserDriver;

        public Hooks(ScenarioContext scenarioContext, IObjectContainer objectContainer)
        {
            this.scenarioContext = scenarioContext;
            this.objectContainer = objectContainer;
        }

        [BeforeScenario]
        public async Task BeforeScenario()
        {
            browserDriver = new BrowserProvider();
            var page = await browserDriver.CreatePageAsync();
            scenarioContext.Set(page);
            objectContainer.RegisterInstanceAs<IPage>(page);
        }

        [AfterScenario]
        public async Task AfterScenario()
        {
            if (browserDriver != null)
            {
                await browserDriver.DisposeAsync();
            }
        }
    }
}