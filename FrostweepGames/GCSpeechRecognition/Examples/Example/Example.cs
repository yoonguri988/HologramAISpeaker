using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace FrostweepGames.Plugins.GoogleCloud.SpeechRecognition.Examples
{
  

    public class Example : MonoBehaviour
    {
        private GCSpeechRecognition _speechRecognition;

        private Button _startRecordButton,
                       _stopRecordButton;

        private Image _speechRecognitionState;

        private Text _speechRecognitionResult;

        private Toggle _isRuntimeDetectionToggle;

        private Dropdown _languageDropdown;

        private InputField _contextPhrases;

        private Dictionary<string, Action> actions = new Dictionary<string, Action>();

        public Animator animator;

        public GameObject Lima;


        //오디오 소스가져오는 부분
        private AudioSource theAudio;

        //오디오 창에서 넣을수 있게 mp3파일(여러개)
        [SerializeField] private AudioClip[] clip;
        [SerializeField] private AudioClip[] hi_voice;
        [SerializeField] private AudioClip[] music;
        [SerializeField] public AudioClip[] gym;
        [SerializeField] public AudioClip[] want;
        [SerializeField] public AudioClip[] joke;
        [SerializeField] public AudioClip[] menu;
        [SerializeField] public AudioClip[] alone;
        [SerializeField] public AudioClip[] pretty;
        [SerializeField] public AudioClip[] love;
        [SerializeField] public AudioClip[] comein;
        [SerializeField] public AudioClip[] comeout;
        [SerializeField] public AudioClip[] doing;
        [SerializeField] public AudioClip[] playing;
        [SerializeField] public AudioClip[] whattodo;
        [SerializeField] public AudioClip[] clothes;
        [SerializeField] public AudioClip[] hope;
        [SerializeField] public AudioClip[] alarm;

        //창에서 넣을수 있게 mp3파일(여러개)
        //[SerializeField] private AudioClip clip_1;
        //[SerializeField] private AudioClip clip_2;
        //[SerializeField] private AudioClip clip_3;

        //움직임 만들기

        void Move()
        {
           // actions.Add("앞", Forward);
           // actions.Add("뒤", Back);
           // actions.Add("위", Up);
           // actions.Add("아래", Down);
          //  actions.Add("오른쪽", Right);
           // actions.Add("왼쪽", Left);


           // actions.Add("소녀", Girl);
           // actions.Add("소년", Boy);
        }

        public static Vector3 target = new Vector3(0, 0, 0);
        public static float x = 0.0f;
        public static float y = 0.0f;
        public static float z = 0.0f;
        //
        //좌표에 더하기 되는 것
        private void Forward()
        {
            z -= 1.0f;
            target = new Vector3(x, y, z);

            Update();
        }

        void Back()
        {
            z += 1.0f;
            target = new Vector3(x, y, z);
            Update();
        }

        void Up()
        {
            y -= 1.0f;
            target = new Vector3(x, y, z);
            Update();
        }

        void Down() 
        {
            y += 1.0f;
            target = new Vector3(x, y, z);
            Update();
        }

        void Right()
        {
            x += 1.0f;
            target = new Vector3(x, y, z);
            Update();

        }
        void Left()
        {
            x -= 1.0f;
            target = new Vector3(x, y, z);
            Update();
        }

        //


        //해당 좌표로 이동하는 것



        float targetTime = 1.0f;
        float currentTime = 0.0f;

        bool flag = false;


        //Scene 이동

        //애니메이션

        public void Cute()
        {
            animator.Play("cute");
        }

        public void Soso()
        {
            animator.Play("Soso");
        }
        public void Best()
        {
            animator.Play("Best");
        }
        public void Feel()
        {
            animator.Play("Feel");
        }
        public void Idontknow()
        {
            animator.Play("Idontknow");
        }
        public void Hi()
        {
            animator.Play("hi");
        }
        public void Music()
        {
            animator.Play("Music");
        }

        public void Gym()
        {
            animator.Play("Samba Dancing");
        }
        public void Joke()
        {
            animator.Play("Chicken Dance");
        }
        public void Menu()
        {
            animator.Play("Hands Forward Gesture");
        }

        public void Alone()
        {
            animator.Play("Praying");
        }
        public void Walk()
        {
            animator.Play("Walking");
        }
        public void Pretty()
        {
            animator.Play("Salsa Dancing");
        }

        public void Love()
        {
            animator.Play("Soccer Tackle");
        }

        public void Comein()
        {
            animator.Play("Dwarf Idle");
        }

        public void Comeout()
        {
            animator.Play("Sword And Shield Casting");
        }

        public void Doing()
        {
            animator.Play("Treading Water");
        }

        public void Playing()
        {
            animator.Play("Start Jumping Jacks");
        }

        public void Whattodo()
        {
            animator.Play("Capoeira");
        }

        public void Clothes()
        {
            animator.Play("Inside Crescent Kick");
        }

        public void Hope()
        {
            animator.Play("Standing Jump");
        }
        public void Alarm_Ani()
        {
            animator.Play("Shrugging");
        }

        //오디오-버튼이눌릴때 실행할 함수
        public void PlaySE()
        {
            //integer로 환산시 0 1 2 3 만 읽힘
            //4가지의 경우의 수 
            int _temp = UnityEngine.Random.Range(0, 7);
            theAudio.mute = false;
            theAudio.clip = clip[_temp];
            
            //해당 녹음파일마다 다르게 행동
            if (_temp == 0)
            {
                Best();
            }
            if (_temp == 1)
            {
                Soso();
            }
            if (_temp == 2)
            {
                Feel();
            }
            if (_temp == 3)
            {
                Best();
            }
            if (_temp == 4)
            {
                Idontknow();
            }
            if (_temp == 5)
            {  
                Feel();
            }
            //오디오 실행
            theAudio.Play();
        }
        public void PlayMenu()
        {

            int _temp = UnityEngine.Random.Range(0, 9);
            theAudio.mute = false;

            //해당 녹음파일마다 다르게 행동
            if (_temp == 0)
            {
                theAudio.clip = menu[_temp];
                theAudio.Play();
            }
            if (_temp == 1)
            {
                theAudio.clip = menu[_temp];
                theAudio.Play();
            }
            if (_temp == 2)
            {
                theAudio.clip = menu[_temp];
                theAudio.Play();
            }
            if (_temp == 3)
            {
                theAudio.clip = menu[_temp];
                theAudio.Play();
            }
            if (_temp == 4)
            {
                theAudio.clip = menu[_temp];
                theAudio.Play();
            }
            if (_temp == 5)
            {
                theAudio.clip = menu[_temp];
                theAudio.Play();
            }
            if (_temp == 6)
            {
                theAudio.clip = menu[_temp];
                theAudio.Play();
            }
            if (_temp == 7)
            {
                theAudio.clip = menu[_temp];
                theAudio.Play();
            }
            if (_temp == 8)
            {
                theAudio.clip = menu[_temp];
                theAudio.Play();
            }
            if (_temp == 9)
            {
                theAudio.clip = menu[_temp];
                theAudio.Play();
            }
            //오디오 실행
            Menu();
        }



        public void PlayAlone()
        {

            int _temp = UnityEngine.Random.Range(0, 9);
            theAudio.mute = false;

            //해당 녹음파일마다 다르게 행동
            if (_temp == 0)
            {
                theAudio.clip = alone[_temp];
                theAudio.Play();
            }
            if (_temp == 1)
            {
                theAudio.clip = alone[_temp];
                theAudio.Play();
            }
            if (_temp == 2)
            {
                theAudio.clip = alone[_temp];
                theAudio.Play();
            }
            if (_temp == 3)
            {
                theAudio.clip = alone[_temp];
                theAudio.Play();
            }
            if (_temp == 4)
            {
                theAudio.clip = alone[_temp];
                theAudio.Play();
            }
            if (_temp == 5)
            {
                theAudio.clip = alone[_temp];
                theAudio.Play();
            }
            if (_temp == 6)
            {
                theAudio.clip = alone[_temp];
                theAudio.Play();
            }
            if (_temp == 7)
            {
                theAudio.clip = alone[_temp];
                theAudio.Play();
            }
            if (_temp == 8)
            {
                theAudio.clip = alone[_temp];
                theAudio.Play();
            }
            if (_temp == 9)
            {
                theAudio.clip = alone[_temp];
                theAudio.Play();
            }
            Alone();
        }
        public void Hi_Voice_monning()
        {
            int _temp = 0;
            theAudio.mute = false;
            theAudio.clip = hi_voice[_temp];
            theAudio.Play();
        }
        public void Hi_Voice_lunch()
        {
            int _temp = 1;
            theAudio.mute = false;
            theAudio.clip = hi_voice[_temp];
            theAudio.Play();
        }
        public void Hi_Voice_dinner()
        {
            int _temp = 2;
            theAudio.mute = false;
            theAudio.clip = hi_voice[_temp];
            theAudio.Play();
        }
        public void Hi_Voice_night()
        {
            int _temp = 3;
            theAudio.mute = false;
            theAudio.clip = hi_voice[_temp];
            theAudio.Play();
        }

        public void PlayMusic()
        {
            int _temp = 0;
            theAudio.mute = false;
            theAudio.clip = music[_temp];
            Music();
            theAudio.Play();
        }

        IEnumerator Playlist()
        {
            int _temp0 = 0;
            int _temp1 = 1;
            theAudio.mute = false;
            theAudio.clip = gym[_temp0];
            theAudio.Play();
            while (true)
            {
                yield return new WaitForSeconds(5.0f);
                if (!theAudio.isPlaying)
                { 
                    theAudio.clip = gym[_temp1];
                    theAudio.Play();
                    theAudio.loop = false;
                }
                break;
            }
        }
        public void PlayGym()
        {
            z += 1.5f;
            target = new Vector3(x, y, z);
            Update();
            StartCoroutine("Playlist");
            Invoke("Gym", 5);           //3초 이후에 Gym 이라는 메서드를 실행해주세요
            Invoke("Reset_Position", 70);

            //Gym();
        }

        public void Reset_Position()
        {
            z -= 1.5f;
            target = new Vector3(x, y, z);
            Update();
        }

        public void Mute()
        {
            theAudio.mute = true;
        }

        public void Want()
        {
            int _temp = UnityEngine.Random.Range(0, 10);
            theAudio.mute = false;
            theAudio.clip = want[_temp];
            theAudio.Play();
        }
        public void PlayJoke()
        {
            //integer로 환산시 0 1 2 3 만 읽힘
            //4가지의 경우의 수 
            int _temp = UnityEngine.Random.Range(0, 9);
            theAudio.mute = false;

            //해당 녹음파일마다 다르게 행동
            if (_temp == 0)
            {
                theAudio.clip = joke[_temp];
                theAudio.Play();
            }
            if (_temp == 1)
            {
                theAudio.clip = joke[_temp];
                theAudio.Play();
            }
            if (_temp == 2)
            {
                theAudio.clip = joke[_temp];
                theAudio.Play();
            }
            if (_temp == 3)
            {
                theAudio.clip = joke[_temp];
                theAudio.Play();
            }
            if (_temp == 4)
            {
                theAudio.clip = joke[_temp];
                theAudio.Play();
            }
            if (_temp == 5)
            {
                theAudio.clip = joke[_temp];
                theAudio.Play();
            }
            if (_temp == 6)
            {
                theAudio.clip = joke[_temp];
                theAudio.Play();
            }
            if (_temp == 7)
            {
                theAudio.clip = joke[_temp];
                theAudio.Play();
            }
            if (_temp == 8)
            {
                theAudio.clip = joke[_temp];
                theAudio.Play();
            }
            if (_temp == 9)
            {
                theAudio.clip = joke[_temp];
                theAudio.Play();
            }
            //오디오 실행
            Joke();
        }
        public void PlayPretty()
        {

            int _temp = UnityEngine.Random.Range(0, 4);
            theAudio.mute = false;

            //해당 녹음파일마다 다르게 행동
            if (_temp == 0)
            {
                theAudio.clip = pretty[_temp];
                theAudio.Play();
            }
            if (_temp == 1)
            {
                theAudio.clip = pretty[_temp];
                theAudio.Play();
            }
            if (_temp == 2)
            {
                theAudio.clip = pretty[_temp];
                theAudio.Play();
            }
            if (_temp == 3)
            {
                theAudio.clip = pretty[_temp];
                theAudio.Play();
            }
            if (_temp == 4)
            {
                theAudio.clip = pretty[_temp];
                theAudio.Play();
            }
            Pretty();
        }

        public void PlayLove()
        {

            int _temp = UnityEngine.Random.Range(0, 4);
            theAudio.mute = false;

            //해당 녹음파일마다 다르게 행동
            if (_temp == 0)
            {
                theAudio.clip = love[_temp];
                theAudio.Play();
            }
            if (_temp == 1)
            {
                theAudio.clip = love[_temp];
                theAudio.Play();
            }
            if (_temp == 2)
            {
                theAudio.clip = love[_temp];
                theAudio.Play();
            }
            if (_temp == 3)
            {
                theAudio.clip = love[_temp];
                theAudio.Play();
            }
            if (_temp == 4)
            {
                theAudio.clip = love[_temp];
                theAudio.Play();
            }
            Love();
        }

        public void PlayComein()
        {

            int _temp = UnityEngine.Random.Range(0, 4);
            theAudio.mute = false;

            //해당 녹음파일마다 다르게 행동
            if (_temp == 0)
            {
                theAudio.clip = comein[_temp];
                theAudio.Play();
            }
            if (_temp == 1)
            {
                theAudio.clip = comein[_temp];
                theAudio.Play();
            }
            if (_temp == 2)
            {
                theAudio.clip = comein[_temp];
                theAudio.Play();
            }
            if (_temp == 3)
            {
                theAudio.clip = comein[_temp];
                theAudio.Play();
            }
            if (_temp == 4)
            {
                theAudio.clip = comein[_temp];
                theAudio.Play();
            }
            Comein();
        }

        public void PlayComeout()
        {

            int _temp = UnityEngine.Random.Range(0, 4);
            theAudio.mute = false;

            //해당 녹음파일마다 다르게 행동
            if (_temp == 0)
            {
                theAudio.clip = comeout[_temp];
                theAudio.Play();
            }
            if (_temp == 1)
            {
                theAudio.clip = comeout[_temp];
                theAudio.Play();
            }
            if (_temp == 2)
            {
                theAudio.clip = comeout[_temp];
                theAudio.Play();
            }
            if (_temp == 3)
            {
                theAudio.clip = comeout[_temp];
                theAudio.Play();
            }
            if (_temp == 4)
            {
                theAudio.clip = comeout[_temp];
                theAudio.Play();
            }
            Comeout();
        }

        public void PlayDoing()
        {

            int _temp = UnityEngine.Random.Range(0, 4);
            theAudio.mute = false;

            //해당 녹음파일마다 다르게 행동
            if (_temp == 0)
            {
                theAudio.clip = doing[_temp];
                theAudio.Play();
            }
            if (_temp == 1)
            {
                theAudio.clip = doing[_temp];
                theAudio.Play();
            }
            if (_temp == 2)
            {
                theAudio.clip = doing[_temp];
                theAudio.Play();
            }
            if (_temp == 3)
            {
                theAudio.clip = doing[_temp];
                theAudio.Play();
            }
            if (_temp == 4)
            {
                theAudio.clip = doing[_temp];
                theAudio.Play();
            }
            Doing();
        }

        public void PlayPlaying()
        {

            int _temp = UnityEngine.Random.Range(0, 4);
            theAudio.mute = false;

            //해당 녹음파일마다 다르게 행동
            if (_temp == 0)
            {
                theAudio.clip = playing[_temp];
                theAudio.Play();
            }
            if (_temp == 1)
            {
                theAudio.clip = playing[_temp];
                theAudio.Play();
            }
            if (_temp == 2)
            {
                theAudio.clip = playing[_temp];
                theAudio.Play();
            }
            if (_temp == 3)
            {
                theAudio.clip = playing[_temp];
                theAudio.Play();
            }
            if (_temp == 4)
            {
                theAudio.clip = playing[_temp];
                theAudio.Play();
            }
            Playing();
        }

        public void PlayWhattodo()
        {

            int _temp = UnityEngine.Random.Range(0, 4);
            theAudio.mute = false;

            //해당 녹음파일마다 다르게 행동
            if (_temp == 0)
            {
                theAudio.clip = whattodo[_temp];
                theAudio.Play();
            }
            if (_temp == 1)
            {
                theAudio.clip = whattodo[_temp];
                theAudio.Play();
            }
            if (_temp == 2)
            {
                theAudio.clip = whattodo[_temp];
                theAudio.Play();
            }
            if (_temp == 3)
            {
                theAudio.clip = whattodo[_temp];
                theAudio.Play();
            }
            if (_temp == 4)
            {
                theAudio.clip = whattodo[_temp];
                theAudio.Play();
            }
            Whattodo();
        }

        public void PlayClothes()
        {

            int _temp = UnityEngine.Random.Range(0, 4);
            theAudio.mute = false;

            //해당 녹음파일마다 다르게 행동
            if (_temp == 0)
            {
                theAudio.clip = clothes[_temp];
                theAudio.Play();
            }
            if (_temp == 1)
            {
                theAudio.clip = clothes[_temp];
                theAudio.Play();
            }
            if (_temp == 2)
            {
                theAudio.clip = clothes[_temp];
                theAudio.Play();
            }
            if (_temp == 3)
            {
                theAudio.clip = clothes[_temp];
                theAudio.Play();
            }
            if (_temp == 4)
            {
                theAudio.clip = clothes[_temp];
                theAudio.Play();
            }
            Clothes();
        }

        public void PlayHope()
        {
            int _temp = 0;

            theAudio.mute = false;
            theAudio.clip = hope[_temp];
            theAudio.Play();
            Hope();
        }

        private Quaternion right = Quaternion.identity;

        public void PlayAnyWhere()
        {
            PlayRight();
            Invoke("PlayLeft", 2);
            Invoke("PlayLeft", 4);
            Invoke("PlayRight", 6);
        }
        public void PlayLeft()
        {

            right.eulerAngles = new Vector3(0, 90, 0);
            Left();
            Walk();
            
        }
        public void PlayRight()
        {

            right.eulerAngles = new Vector3(0, -90, 0);
            Right();
            Walk();
            Invoke("Reset_AnyWhere", 2);
        }
        public void Reset_AnyWhere()
        {
            right.eulerAngles = new Vector3(0, 0, 0);
            Update();
        }
        private DateTime time;
        public void Alarm_5()
        {
            time = DateTime.Now.AddMinutes(5);
        }
        public void Alarm_10()
        {
            time = DateTime.Now.AddMinutes(10);
        }
        public void Alarm_2()
        {
            time = DateTime.Now.AddMinutes(1);
            //while (true)
            //{
            //    if (time == DateTime.Now)
            //    {
           //         int _temp = 0;
            //        theAudio.mute = false;
            //        theAudio.clip = alarm[_temp];
            //        theAudio.Play();
           //         Alarm_Ani();
            //        break;
            //    }
            //}
        }
        private void Start()
        {
            _speechRecognition = GCSpeechRecognition.Instance;
            _speechRecognition.RecognitionSuccessEvent += RecognitionSuccessEventHandler;
            _speechRecognition.NetworkRequestFailedEvent += SpeechRecognizedFailedEventHandler;
            _speechRecognition.LongRecognitionSuccessEvent += LongRecognitionSuccessEventHandler;

            _startRecordButton = transform.Find("Canvas/Button_StartRecord").GetComponent<Button>();

            _stopRecordButton = transform.Find("Canvas/Button_StopRecord").GetComponent<Button>();

            _speechRecognitionState = transform.Find("Canvas/Image_RecordState").GetComponent<Image>();

            _speechRecognitionResult = transform.Find("Canvas/Text_Result").GetComponent<Text>();

            _isRuntimeDetectionToggle = transform.Find("Canvas/Toggle_IsRuntime").GetComponent<Toggle>();

            _isRuntimeDetectionToggle.isOn = true;

            _languageDropdown = transform.Find("Canvas/Dropdown_Language").GetComponent<Dropdown>();

            _contextPhrases = transform.Find("Canvas/InputField_SpeechContext").GetComponent<InputField>();

            _startRecordButton.onClick.AddListener(StartRecordButtonOnClickHandler);
            _stopRecordButton.onClick.AddListener(StopRecordButtonOnClickHandler);

            _speechRecognitionState.color = Color.white;
            _startRecordButton.interactable = true;
            _stopRecordButton.interactable = false;

            _languageDropdown.ClearOptions();

            


            for (int i = 0; i < Enum.GetNames(typeof(Enumerators.LanguageCode)).Length; i++)
            {
                _languageDropdown.options.Add(new Dropdown.OptionData(((Enumerators.LanguageCode)i).ToString()));
            }

            _languageDropdown.onValueChanged.AddListener(LanguageDropdownOnValueChanged);

            _languageDropdown.value = _languageDropdown.options.IndexOf(_languageDropdown.options.Find(x => x.text == Enumerators.LanguageCode.ko_KR.ToString()));

            //오디오파일부분
            //오디오시작하자마자 오디오를 찾게만드는 부분
            theAudio = GetComponent<AudioSource>();
            Invoke("PlayAnyWhere", 2);
            
        }
        Vector3 lookDirection;
        void Update()
        {
            
            for (int i = 9; i< 20; i++)
            {
                String TimeHour = "";
                if (i < 10)
                {
                    TimeHour = "0" + i;
                }
                else
                {
                    TimeHour = "" + i;
                }
                if (DateTime.Now.ToString("HHmmss") == TimeHour + "0000")
                { 
                    Want();
                    
                }
                if (DateTime.Now.ToString("HHmmss") == TimeHour + "3000")
                { 
                    Want();
                    
                }
            }
            
            Lima.transform.rotation = Quaternion.Slerp(Lima.transform.rotation, right, 0.25f);
            transform.position = Vector3.Lerp(transform.position, target, 0.02f);
            if (flag) 
                return;

            currentTime += Time.smoothDeltaTime;
            if (currentTime >= targetTime && !flag)
            {
                flag = true;
                StartRecordButtonOnClickHandler();
            }

        }




        private void OnDestroy()
        {
            _speechRecognition.RecognitionSuccessEvent -= RecognitionSuccessEventHandler;
            _speechRecognition.NetworkRequestFailedEvent -= SpeechRecognizedFailedEventHandler;
            _speechRecognition.LongRecognitionSuccessEvent -= LongRecognitionSuccessEventHandler;
        }


        private void StartRecordButtonOnClickHandler()
        {
            _startRecordButton.interactable = false;
            _stopRecordButton.interactable = true;
            _speechRecognitionState.color = Color.red;
            _speechRecognitionResult.text = string.Empty;
            _speechRecognition.StartRecord(_isRuntimeDetectionToggle.isOn);
        }

        private void StopRecordButtonOnClickHandler()
        {
            ApplySpeechContextPhrases();

            _stopRecordButton.interactable = false;
            _speechRecognitionState.color = Color.yellow;
            _speechRecognition.StopRecord();
        }

        private void LanguageDropdownOnValueChanged(int value)
        {
            _speechRecognition.SetLanguage((Enumerators.LanguageCode)value);
        }

        private void ApplySpeechContextPhrases()
        {
            string[] phrases = _contextPhrases.text.Trim().Split(","[0]);

            if (phrases.Length > 0)
                _speechRecognition.SetContext(new List<string[]>() { phrases });
        }

        private void SpeechRecognizedFailedEventHandler(string obj, long requestIndex)
        {
            _speechRecognitionResult.text = "Speech Recognition failed with error: " + obj;

            if (!_isRuntimeDetectionToggle.isOn)
            {
                _speechRecognitionState.color = Color.green;
                _startRecordButton.interactable = true;
                _stopRecordButton.interactable = false;
            }
        }

        private void RecognitionSuccessEventHandler(RecognitionResponse obj, long requestIndex)
        {
            if (!_isRuntimeDetectionToggle.isOn)
            {
                _startRecordButton.interactable = true;
                _speechRecognitionState.color = Color.green;
            }


            //음성인식 응용

            if (obj != null)
            {
                 foreach (var item in obj.results)
                {
                    foreach(var alternative in item.alternatives)
                    {
                        
                        //내 위치에서 플러스

                        if (alternative.transcript.ToLower().Equals("앞으로"))
                        {
                            Debug.Log("앞으로 갔습니다.");
                            Forward();
                        }

                        if (alternative.transcript.ToLower().Equals("뒤로가"))
                        {
                            Debug.Log("뒤로 갔습니다.");
                            Back();
                        }

                        if (alternative.transcript.ToLower().Equals("위로"))
                        {
                            Debug.Log("위로 갔습니다.");
                            Up();
                        }

                        if (alternative.transcript.ToLower().Equals("아래로"))
                        {
                            Debug.Log("아래로 갔습니다.");
                            Down();
                        }

                        if (alternative.transcript.ToLower().Equals("오른쪽으로"))
                        {
                            Debug.Log("오른쪽으로 갔습니다.");
                           // Right();
                        }

                        if (alternative.transcript.ToLower().Equals("왼쪽으로"))
                        {
                            Debug.Log("왼쪽으로 갔습니다.");
                            Left();
                        }

                        //

                        //애니메이션

                        if (alternative.transcript.ToLower().Equals("귀여워"))
                        {
                            Debug.Log("귀여워.");
                            Cute();
                        }

                        if (alternative.transcript.ToLower().Equals("기분 어때"))
                        {
                            Debug.Log("기분을 나타냅니다.");
                            PlaySE();
                           
                        }
                        if (alternative.transcript.ToLower().Equals("노래 틀어 줘"))
                        {
                            Debug.Log("아모르파티.");
                            PlayMusic();
                        }

                        if (alternative.transcript.ToLower().Equals("조용히 해"))
                        {
                            Debug.Log("소리를 끕니다.");
                            Mute();
                        }

                        if (alternative.transcript.ToLower().Equals("체조 하자"))
                        {
                            Debug.Log("체조를합니다.");
                            PlayGym();
                        }
                   
                        if (alternative.transcript.ToLower().Contains("귀여") || alternative.transcript.ToLower().Contains("귀엽"))
                        {
                            Debug.Log("귀여워.");
                            Cute();
                        }

                        if (alternative.transcript.ToLower().Contains("기분 어때") || alternative.transcript.ToLower().Contains("상태 어때"))
                        {
                            Debug.Log("기분을 나타냅니다.");
                            PlaySE();

                        }
                        if (alternative.transcript.ToLower().Contains("노래"))
                        {
                            Debug.Log("아모르파티.");
                            PlayMusic();
                        }

                        if (alternative.transcript.ToLower().Contains("조용") || alternative.transcript.ToLower().Contains("닥쳐"))
                        {
                            Debug.Log("소리를 끕니다.");
                            Mute();
                        }

                        if (alternative.transcript.ToLower().Contains("체조"))
                        {
                            Debug.Log("체조를합니다.");
                            PlayGym();
                        }
                        if (alternative.transcript.ToLower().Contains("안녕") || alternative.transcript.ToLower().Contains("반가"))
                        {
                            for (int t = 10; t <= 15; t++)
                            {
                                String time = t + "";
                                if (DateTime.Now.ToString("HH") == time)
                                {
                                    Debug.Log("점심인사를 합니다.");
                                    Hi();
                                    Hi_Voice_lunch();
                                }
                            }
                            for (int t = 16; t <= 20; t++)
                            {
                                String time = t + "";
                                if (DateTime.Now.ToString("HH") == time)
                                {
                                    Debug.Log("저녁인사를 합니다.");
                                    Hi();
                                    Hi_Voice_dinner();
                                }
                            }
                            for (int t = 21; t <= 24; t++)
                            {
                                String time = t + "";
                                if (DateTime.Now.ToString("HH") == time)
                                {
                                    Debug.Log("밤인사를 합니다.");
                                    Hi();
                                    Hi_Voice_night();
                                }
                            }
                            for (int t = 0; t <= 2; t++)
                            {
                                String time = "0" + t;
                                if (DateTime.Now.ToString("HH") == time)
                                {
                                    Debug.Log("밤인사를 합니다.");
                                    Hi();
                                    Hi_Voice_night();
                                }
                            }
                            for (int t = 5; t <= 9; t++)
                            {
                                String time = "0" + t;
                                if (DateTime.Now.ToString("HH") == time)
                                {
                                    Debug.Log("아침인사를 합니다.");
                                    Hi();
                                    Hi_Voice_monning();
                                }
                            }
                        }
                        if (alternative.transcript.ToLower().Contains("농담") || alternative.transcript.ToLower().Contains("재밌는 얘기") || alternative.transcript.ToLower().Contains("재미있는 얘기") || alternative.transcript.ToLower().Contains("재미있는 이야기") || alternative.transcript.ToLower().Contains("재밌는 이야기"))
                        {
                            Debug.Log("농담합니다");
                            PlayJoke();
                        }

                        if (alternative.transcript.ToLower().Contains("메뉴") || alternative.transcript.ToLower().Contains("뭐 먹지"))
                        {
                            Debug.Log("메뉴추천");
                            PlayMenu();
                        }


                        if (alternative.transcript.ToLower().Contains("외롭") || alternative.transcript.ToLower().Contains("외로"))
                        {
                            Debug.Log("외로움을 달랩니다");
                            PlayAlone();
                        }

                        if (alternative.transcript.ToLower().Contains("예뻐") || alternative.transcript.ToLower().Contains("예쁘"))
                        {
                            Debug.Log("예쁘다");
                            PlayPretty();
                        }

                        if (alternative.transcript.ToLower().Contains("사랑"))
                        {
                            Debug.Log("사랑해");
                            PlayLove();
                        }


                        if (alternative.transcript.ToLower().Contains("왔어") || alternative.transcript.ToLower().Contains("왔다"))
                        {
                            Debug.Log("나왔어");
                            PlayComein();
                        }

                        if (alternative.transcript.ToLower().Contains("갈게") || alternative.transcript.ToLower().Contains("다녀올게") || alternative.transcript.ToLower().Contains("갔다 올게"))
                        {
                            Debug.Log("다녀올게");
                            PlayComeout();
                        }

                        if (alternative.transcript.ToLower().Contains("뭐 해") || alternative.transcript.ToLower().Contains("뭐 하"))
                        {
                            Debug.Log("뭐하고있었어");
                            PlayDoing();
                        }

                        if (alternative.transcript.ToLower().Contains("놀아") || alternative.transcript.ToLower().Contains("놀자"))
                        {
                            Debug.Log("놀아주기");
                            PlayPlaying();
                        }

                        if (alternative.transcript.ToLower().Contains("뭐 하지") || alternative.transcript.ToLower().Contains("할 거"))
                        {
                            Debug.Log("놀아주기");
                            PlayWhattodo();
                        }

                        if (alternative.transcript.ToLower().Contains("뭐 입지") || alternative.transcript.ToLower().Contains("옷 추천") || alternative.transcript.ToLower().Contains("옷 좀 추천"))
                        {
                            Debug.Log("옷고르기");
                            PlayClothes();
                        }

                        if (alternative.transcript.ToLower().Contains("소망"))
                        {
                            Debug.Log("소망아");
                            PlayHope();
                        }

                        if (alternative.transcript.ToLower().Contains("움직") || alternative.transcript.ToLower().Contains("이동"))
                        {
                            Debug.Log("와리가리");
                            PlayAnyWhere();
                        }
                        

                        //


                    }
                }
            }
            //


            if (obj != null && obj.results.Length > 0)
            {
                _speechRecognitionResult.text = "Speech Recognition succeeded! Detected Most useful: " + obj.results[0].alternatives[0].transcript;    

                var words = obj.results[0].alternatives[0].words;

                if (words != null)
                {
                    string times = string.Empty;

                    foreach (var item in obj.results[0].alternatives[0].words)
                        times += "<color=green>" + item.word + "</color> -  start: " + item.startTime + "; end: " + item.endTime + "\n";

                    _speechRecognitionResult.text += "\n" + times;
                }

                string other = "\nDetected alternative: ";

                foreach (var result in obj.results)
                {
                    foreach (var alternative in result.alternatives)
                    {
                        if (obj.results[0].alternatives[0] != alternative)
                            other += alternative.transcript + ", ";
                    }
                }

                _speechRecognitionResult.text += other;
            }
            else
            {
                _speechRecognitionResult.text = "Speech Recognition succeeded! Words are no detected.";
            }
        }

        private void LongRecognitionSuccessEventHandler(OperationResponse operation, long index)
        {
            if (!_isRuntimeDetectionToggle.isOn)
            {
                _startRecordButton.interactable = true;
                _speechRecognitionState.color = Color.green;
            }

            if (operation != null && operation.response.results.Length > 0)
            {
                _speechRecognitionResult.text = "Long Speech Recognition succeeded! Detected Most useful: " + operation.response.results[0].alternatives[0].transcript;

                string other = "\nDetected alternative: ";

                foreach (var result in operation.response.results)
                {
                    foreach (var alternative in result.alternatives)
                    {
                        if (operation.response.results[0].alternatives[0] != alternative)
                            other += alternative.transcript + ", ";
                    }
                }

                _speechRecognitionResult.text += other;
                _speechRecognitionResult.text += "\nTime for the recognition: " + 
                    (operation.metadata.lastUpdateTime - operation.metadata.startTime).TotalSeconds + "s";
            }
            else
            {
                _speechRecognitionResult.text = "Speech Recognition succeeded! Words are no detected.";
            }
        }
    }
}