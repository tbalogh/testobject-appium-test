import org.junit.After;
import org.junit.Before;
import org.junit.Test;
import io.appium.java_client.android.AndroidDriver;
import org.openqa.selenium.remote.DesiredCapabilities;
import java.net.URL;


public class BasicTest {

    private AndroidDriver driver;

    @Before
    public void setUp() throws Exception {
        DesiredCapabilities capabilities = new DesiredCapabilities();
        capabilities.setCapability("testobject_api_key", "my_api_key");
        capabilities.setCapability("testobject_device", "Samsung_Galaxy_S6_real");
        URL server = new URL("url_given_in_testobject_project");

        driver = new AndroidDriver(server, capabilities);
    }

    @Test
    public void firstTest() throws Exception {
        System.out.println("Driver set up properly");
    }

    @After
    public void tearDown() throws Exception {
        driver.quit();
    }
}
