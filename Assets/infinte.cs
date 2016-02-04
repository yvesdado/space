using UnityEngine;
using System.Collections;

public class infinte : MonoBehaviour {


	private Transform tx;
	private ParticleSystem.Particle[] points;

	public int starsMax=100;
	public float starSize=1;
	public float starDistance=10;
	public float starclipDistance=1;
	private float starDistanceSqr;
	private float starclipDistanceSqr;



	// Use this for initialization
	void Start () {
		tx = transform;
		starDistanceSqr = starDistance * starDistance;
		starclipDistanceSqr = starclipDistance * starclipDistance;
	}
	private void CreateStars(){

		points = new ParticleSystem.Particle[starsMax]; 
		for (int i=0; i< starsMax; i++) {
			points[i].position=Random.insideUnitSphere*starDistance+tx.position;
			points[i].color= new Color(1,1,1,1);
			points[i].size=starSize;

				 
		}

	}
	
	// Update is called once per frame
	void Update () {
		if (points == null) CreateStars ();

		for (int i=0; i<starsMax; i++) {
			if((points[i].position-tx.position).sqrMagnitude>starDistanceSqr){
				points[i].position=Random.insideUnitSphere.normalized*starDistance+tx.position;
			}
			if((points[i].position-tx.position).sqrMagnitude<=starclipDistanceSqr){
				float percent=(points[i].position-tx.position).sqrMagnitude / starclipDistanceSqr;
				points[i].color= new Color(1,1,1,percent);
				points[i].size=percent*starSize;

			}
		} 



		this.GetComponent<ParticleSystem>().SetParticles (points, points.Length);
	}
}
