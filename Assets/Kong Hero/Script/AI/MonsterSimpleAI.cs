using UnityEngine;
using System.Collections;
using System.Threading.Tasks;

public class MonsterSimpleAI : EnemyAI {
	[Header("Owner Setup")]
	public Animator animator;
	public string hitEventName="n/a";
	public string deadEventName="dead";

	protected override void HitEvent ()
	{
		base.HitEvent ();
		if (isDead)
			Dead ();

		if (animator != null && hitEventName.CompareTo ("n/a") != 0)
			animator.SetTrigger (hitEventName);
	}

	public override void Update ()
	{
		base.Update ();

	}

	protected override void Dead ()
	{
		base.Dead ();
        Destroy(gameObject, 1f);
        if (animator != null && deadEventName.CompareTo ("n/a") != 0)	
			animator.SetTrigger(deadEventName);

		

		/*SetForce(0, 5);
		controller.HandlePhysic = false;*/
	}

	protected override void OnRespawn ()
	{
		base.OnRespawn ();
		controller.HandlePhysic = true;
	}

    public IEnumerator PlayDeadAnimation(float delay)
    {
        if (animator != null && deadEventName.CompareTo("n/a") != 0)
            animator.SetTrigger(deadEventName);
        yield return new WaitForSeconds(delay);
        gameObject.SetActive(false);

    }
}
