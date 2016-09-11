using Nez;
using System.Collections;
using vampsgame;

public class DamageComponent : Component
	{
	// we'll store a reference to our SimpleMover for easy access
	SimpleMover _mover;

	// this method is called when a Component is added to an Entity. It is called after all the Components are added in a frame so it is
	// safe to access the other Components from here.
	public virtual void onAddedToEntity()
		{
		// we can access any other Components on the Entity via the getComponent method. Just pass in the Type of the Component and it
		// will return the Component or null if no Component of that Type is on the Entity.
		_mover = entity.getComponent<SimpleMover>();
		}


	// this method is called elsewhere (perhaps when a bullet hits the Entity). It reduces the SimpleMovers speed for 2 seconds
	public void takeDamage()
		{
		// reduce the SimpleMovers speed
		_mover.speed = 70f;

		// use the TimerManager to schedule a callback after 2 seconds have elapsed
		Core.schedule(2f, t => _mover.speed = 100f);
		}


	public void takeDamageTwo()
		{
		// reduce the SimpleMovers speed
		_mover.speed = 70f;

		// use a coroutine to reset the SimpleMovers speed after 2 seconds have elapsed
		Core.startCoroutine(resetSpeedAfterDelay());
		}


	IEnumerator resetSpeedAfterDelay()
		{
		// let the CoroutineManager know we want to wait for 2 seconds
		yield return Coroutine.waitForSeconds(2f);

		// reset the speed
		_mover.speed = 100f;
		}
	}