//This is a test Code am currently learning, I have not implemented it to other Tutorail Script
using System.Collections;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] TMP_Text testText;
    [SerializeField] TMP_Text tutorialText;
    public float typingSpeed = 0.1f;
    public string[] lines;
    [SerializeField] int index;
    [SerializeField] GameObject frame;
    [SerializeField] GameObject tutorailPopups;
    [SerializeField] AudioSource robotAudioSource;
    [SerializeField] bool onetime = false;
    [SerializeField] bool twotime = false;
    [SerializeField] bool inside = true;
    [SerializeField] bool wmove = false;
    [SerializeField] bool move = true;

    [SerializeField] Player_Control playerControl;

    async private void Start()
    {
        tutorailPopups.SetActive(false);
        tutorialText.gameObject.SetActive(false);
        testText.text = string.Empty;
        DialogStart();
        await Task.Delay(6500);
        move = true;
        wmove = true;
    }
    async private void Update()
    {
        if (!wmove && move)
        {


            if (Input.GetKey(KeyCode.W))
            {


                testText.text = lines[index];
                index = 6;
                testText.text = lines[index];
                Wpress();
                StopAllCoroutines();
                move = false;
                wmove = false;
                await Task.Delay(2000);
                index = 0;
                testText.text = lines[index];

            }


        }
        if (wmove & move)
        {

            if (Input.GetKey(KeyCode.W))
            {

                testText.text = lines[index];
                index = 5;
                testText.text = lines[index];
                Wpress();
                StopAllCoroutines();
                move = false;
                wmove = false;
            }




            if (inside)
            {
                if (Input.anyKey && !Input.GetKey(KeyCode.W))
                {
                    if (!onetime && !twotime)
                    {

                        if (testText.text == lines[index] || Input.GetKey(KeyCode.W))
                        {

                            index = 1;
                            testText.text = string.Empty;
                            AnOtherKey();
                            onetime = true;
                            twotime = true;

                            wmove = true;
                        }


                    }



                    if (onetime && twotime)
                    {
                        if (testText.text == lines[index = 1])
                        {
                            testText.text = lines[index];

                            index = 2;
                            testText.text = lines[index];
                            AnOtherKey();
                            twotime = false;
                            onetime = true;

                            wmove = true;

                        }

                    }
                    if (!twotime && onetime)
                    {
                        if (testText.text == lines[index = 2])
                        {
                            testText.text = lines[index];
                            index = 3;
                            AnOtherKey();
                            twotime = true;
                            onetime = false;

                            wmove = true;
                        }

                    }

                    if (twotime && !onetime)
                    {
                        if (testText.text == lines[index = 3])
                        {
                            playerControl.TakeDamage(50);
                            playerControl.DamageAudioSource.Play();

                            index = 4;
                            AnOtherKey();
                            testText.text = lines[index];
                            onetime = false;
                            twotime = true;



                            wmove = true;
                        }
                        if (testText.text == lines[index = 4])
                        {
                            playerControl.TakeDamage(50);
                            playerControl.DamageAudioSource.Play();


                        }

                    }


                }



            }

        }

    }
    private void DialogStart()
    {
        index = 0;
        StartCoroutine(TypeLine());

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag is "Player")
        {
            tutorialText.gameObject.SetActive(false);
            tutorailPopups.SetActive(true);
            frame.SetActive(true);
            testText.gameObject.SetActive(true);
            robotAudioSource.Play();

        }
        inside = true;
    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag is "Player")
        {
            tutorialText.gameObject.SetActive(false);
            tutorailPopups.SetActive(true);
            frame.SetActive(true);
            testText.gameObject.SetActive(true);



        }


    }

    void OnTriggerExit(Collider other)
    {

        testText.gameObject.SetActive(false);
        tutorailPopups.SetActive(false);


    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            testText.text += c;

            yield return new WaitForSeconds(typingSpeed);


        }

    }
    void Wpress()
    {
        if (index == 3)
        {

            testText.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            tutorailPopups.SetActive(false);
            StartCoroutine(TypeLine());
        }


    }
    void AnOtherKey()
    {
        if (index >= 1)
        {

            testText.text = string.Empty;
            StartCoroutine(TypeLine());

        }
        else
        {
            tutorailPopups.SetActive(false);
            StartCoroutine(TypeLine());
        }
    }


}