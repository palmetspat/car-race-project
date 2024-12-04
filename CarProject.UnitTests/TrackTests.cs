﻿using CarProject.Logic;

namespace CarProject.UnitTests;

[TestClass]
public class TrackTests
{

  [TestMethod]
  public void ItShouldSaveTheStartSectionOfATrack_GivenAnyNumbersOfSections()
  {
    Section 
      startSection = new(50 , 300),
      middleSection = new(70 , 500),
      lastSection = new(60 , 200);
    List<Section> trackList = [ startSection , middleSection , lastSection ];
   
    Track track = new(trackList);

    Assert.AreEqual(startSection , track.StartSection);
  }

}