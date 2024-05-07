using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Testbutton
{
    // A Test behaves as an ordinary method
    [Test]
    public void TestbuttonSimplePasses()
    {
        // Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator PlayButtonOpensGameScene()
    {
        // Load the Intro scene
        SceneManager.LoadScene("Intro");

        // Wait for the scene to load
        yield return new WaitForSeconds(1f);

        // Find the Play button
        GameObject playButton = GameObject.Find("Play");

        // Assert that the button is not null
        Assert.IsNotNull(playButton, "Play button not found in Intro scene");

        // Simulate a button click
        playButton.GetComponent<Button>().onClick.Invoke();

        // Wait for the scene transition
        yield return new WaitForSeconds(1f);

        // Assert that the current scene is now the Game scene
        Assert.AreEqual("Game", SceneManager.GetActiveScene().name, "Game scene not loaded after clicking Play button");
    }

}
