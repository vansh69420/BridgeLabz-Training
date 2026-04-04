using System;
using System.Reflection.Metadata;
public interface ITrackable
{
   void TrackWorkout(UserProfile user, Workout workout);
}