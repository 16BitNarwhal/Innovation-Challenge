# <img src="https://user-images.githubusercontent.com/74038190/213844263-a8897a51-32f4-4b3b-b5c2-e1528b89f6f3.png" width="50px" />VOffice: VR Co-Working and Advisory Spaces for Entrepreneurs <img src="https://user-images.githubusercontent.com/74038190/213844263-a8897a51-32f4-4b3b-b5c2-e1528b89f6f3.png" width="50px" />

> VOffice is a platform that allows you to collaborate with your coworkers in real time in a VR environment, and seek advice from AI-Powered Advisors...
>
> Submitted to Velocity - The Future of Finance Innovation Challenge 2023!

<!-- PROJECT SHIELDS -->
![Contributors][contributors-shield]
![Commits][commits-shield]
![Code Size][code-size-shield]
![Forks][forks-shield]
![Stargazers][stars-shield]
![Issues][issues-shield]
![MIT License][license-shield]


<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/iankorovinsky/hack-the-north-2023">
    <img src="logo.jpg" alt="Logo" width="100%" height="100%">
  </a>

  <p align="center">
    Say goodbye to déjà vu. 
    <br />
  </p>

</div>

<!-- ABOUT THE PROJECT -->
## About The Project

[![Product Name Screen Shot][product-screenshot]](https://devpost.com/software/dejavu)

Introducing VOffice, a groundbreaking virtual reality platform designed to revolutionize the way remote teams and entrepreneurs collaborate. With VOffice, you'll step into a dynamic world where distance is no longer a barrier to productivity and innovation. Harnessing the power of cutting-edge VR technology, VOffice offers seamless access to virtual co-working spaces that feel just like the real thing, fostering a sense of camaraderie and shared purpose.

But that's not all – VOffice goes beyond the ordinary with its AI-powered advisors. Imagine having intelligent, data-driven insights at your fingertips, providing invaluable guidance and support for your business endeavors. Whether you're seeking strategic advice, market trends, or innovative solutions, VOffice's advisors are here to empower you every step of the way.

Experience a new era of remote work with VOffice, where collaboration knows no bounds and innovation knows no limits. Elevate your team's potential and unlock unparalleled opportunities in the virtual realm. Welcome to the future of work, welcome to VOffice.

### Built With

Here are the major languages/technologies we used for creating our project:

* [![Next][Next.js]][Next-url]
* [![Python][Python]][Python-url]
* [![Google Cloud][Google-Cloud]][Google-Cloud-url]
* [![OpenCV][OpenCV]][OpenCV-url]
* [![OpenAI Whisper][OpenAI-Whisper]][OpenAI-Whisper-url]
* [![SciKit-Learn][SciKit-Learn]][SciKit-Learn-url]

And not to forget, here are some APIs and libraries that we were able to include in the process:

- [Cohere](https://cohere.com/)
- [PyAudio](https://pypi.org/project/PyAudio/)
- [Transformers](https://rpradeepmenon.medium.com/introduction-to-large-language-models-and-the-transformer-architecture-534408ed7e61)
- [Contrastive Language-Image Pretraining: CLIP](https://github.com/openai/CLIP)
- [MoviePy](https://pypi.org/project/moviepy/)

<!-- GETTING STARTED -->
## Installation (For Developers)

This is an example of how you may give instructions on setting up your project locally. To get a local copy up and running follow these simple example steps.

### Step 1: Enable Developer Mode for Oculus Quest

```
Open the Oculus Mobile app on your Phone
Go to settings
Select your Oculus Quest (make sure your Quest is powered on)
Select More Settings
Select Developer Mode and enable it

```

### Step 2: Install VRsideloader for Windows or Mac

```
Download the Headjack VRsideloader for Mac or PC
Install on your computer and Open
Wait for the Android Platform tools to finish installing
```

### Step 3: Install the APK file on your Oculus Quest

```
Connect your Oculus Quest to your computer with an USB cable
Put on your Oculus Quest and allow Access Permissions
Obtain an .apk file for install on your Oculus Quest
Drag & drop the .apk file onto the VRsideloader and wait for the installation to finish
```

### Step 4: Start the Installed App on Your VR device

```
Put on your Oculus Quest
Tab the Apps Button or Libary button (older software versions) in the Main Menu
Tab Unknown Sources
Start the app you just installed
```

And there we go! VOffice should be up and running!

<!-- OUR STORY -->

## Our Story

### Inspiration Behind VOffice

In the realm of modern work, where physical office spaces seemed like relics of a bygone era, we, the creators of VOffice, embarked on an extraordinary journey. Picture us, a tight-knit team of visionaries, minds buzzing with the potential of virtual reality. We craved to recreate that palpable energy of a bustling co-working space, where creativity flowed like a river and collaboration was second nature. And so, VOffice came to life – a vibrant tapestry of interconnected virtual worlds, each meticulously crafted to evoke the essence of a bustling office floor. 🚀💡

But we didn't stop there. In an age where knowledge is paramount, we summoned AI-powered advisors, virtual mentors that sift through mountains of data to provide sage counsel and illuminate the path ahead. VOffice became more than just a platform; it was an epic odyssey of digital transformation, inviting teams and entrepreneurs to embark on a thrilling new adventure in work. 🌐📊

With every line of code and every pixel meticulously placed, our dedication to VOffice was unwavering. We envisioned a space where the boundaries between physical and digital were blurred, where the essence of collaboration transcended screens and distance. Each virtual co-working space became a canvas, painted with the aspirations and dreams of countless professionals striving for excellence in their endeavors. The AI-powered advisors, tirelessly crunching data and providing insightful guidance, became trusted allies in the pursuit of success. 💻🌟

And so, the story of VOffice continues, an ongoing saga of evolution and innovation, forever dedicated to reshaping the way we work, connect, and thrive in this brave new world. 🚀🌟

### How We Built VOffice 

For the graphics, we used the 3D Unity Editor. We found some premade assets online, given our limited experience with 3D modelling, and we put them together to create our office environment. We made most of our objects interactable, and for an extra-fun experience, we included a couple of easter eggs. See if you can find them all! 🎥☁️

For our backend, we used C# and we scripted in the integrated Visual Studio IDE. We integrated OpenAI APIs, including text completion and Whisper speech-to-text, in order to power our advisors. In order to be able to make our advisors speak their LLM-powered thoughts, we utilized Amazon Web Service's (AWS) Polly model. 🖥️🚀

Finally, in order to design our deliverables, we used Framer to develop our website, and we leveraged a combination of Figma and Canva to design our pitch and visual assets. 🔎🌟

### Challenges We Overcame at VOffice 

Creating VOffice was like embarking on a wild expedition through the uncharted territories of virtual reality. We delved into the realm of Unity, wrestling with its complexities to craft a seamless and immersive experience for remote teams and entrepreneurs alike. The challenge lay in not just understanding, but mastering Unity's intricacies, as we sought to bring our vision to life. Through countless hours of trial and error, we forged a path that merged creativity and technology, giving birth to a platform that felt like a second home in the digital world. 🌌🖥️

Integrating game objects and scripts was akin to solving an intricate puzzle, each piece holding the key to a smoother, more intuitive user experience. We meticulously fine-tuned every element, from the smallest pixel to the grandest virtual space, ensuring that they seamlessly interacted to create a harmonious environment. It was a dance of algorithms and creativity, a ballet of bytes and imagination. The challenges were aplenty, but with each obstacle conquered, our platform grew stronger and more refined, emerging as a testament to the power of persistence and innovation. 🎩🎮

Connecting AWS and OpenAI to Unity was a feat that required weaving together the threads of cutting-edge technology. It was like orchestrating a symphony of cloud computing and artificial intelligence, harmonizing their capabilities to empower VOffice with the wisdom of digital advisors. This task demanded a deep understanding of both platforms, as we navigated through their intricacies and forged connections that would ensure a seamless flow of information. With every successful integration, we brought VOffice one step closer to becoming a game-changer in the world of remote collaboration. 🎶🧠

### Accomplishments We Celebrate at VOffice 

Embarking on the journey of creating VOffice, we started with a blank canvas and an ambitious dream. Learning Unity 3D from scratch was no small feat, but the thrill of mastering a new frontier of technology fueled our determination. With every line of code, every 3D model, and every test run, we witnessed our proficiency grow, turning what once seemed like an insurmountable challenge into a triumph. We emerged not only as creators of a VR platform but as adept navigators of Unity's intricate landscapes, proving that with dedication and passion, we can conquer any learning curve. 🚀📚

Integrating game objects and scripts was where our creativity truly took flight. We transformed ideas into tangible, interactive elements, each contributing to the immersive experience of VOffice. It was like bringing a fantastical world to life, one line of code at a time. As we fine-tuned and perfected every interaction, we realized the power of persistence and innovation. Our platform became a testament to the magic that happens when imagination meets technology, a testament that still resonates in every virtual co-working space. 🌟🎮

Connecting AWS and OpenAI to Unity was akin to forging a bridge between worlds. It was a feat that demanded precision, ingenuity, and a deep understanding of these powerful platforms. With unwavering determination, we harnessed the potential of cloud computing and artificial intelligence, infusing VOffice with the wisdom of AI-powered advisors. The result was a seamless fusion of cutting-edge technology, allowing us to redefine the boundaries of remote collaboration. Our accomplishment echoed through the digital landscape, proving that innovation knows no bounds. 🌐💡

### Lessons Learned from VOffice's Journey

Crafting VOffice was a thrilling odyssey, filled with invaluable lessons that sculpted our journey. We discovered that playtest scripts, while essential for refining the user experience, can sometimes be as capricious as a mischievous sprite, requiring constant adjustment as we forged ahead. Debugging, the unsung hero of code refinement, proved to be a formidable adversary in Unity's realm, demanding patience and precision. Yet, it was an indispensable companion on our quest for flawless functionality, a reminder that even in the digital realm, a discerning eye is paramount. 🕹️🔍

Oh, the dance of assets! We learned that the groundwork of rigging should always be laid from the very beginning. Like a ship's anchor, rigging provides stability and flexibility, ensuring smooth sailing through the development process. Neglecting this crucial step, we found, led to a tangled web of rework and adjustments. It became apparent that foresight and meticulous planning pay dividends in the long run, a truth that resonates in every meticulously designed co-working space within VOffice. 🎭✨

### The Future of VOffice: Where Innovation Thrives! 

In the unfolding chapters of VOffice's evolution, we envision a tapestry woven with groundbreaking features. Picture a landscape where communication transcends mere text and speech bubbles; it's a realm where you and your teammates seamlessly interact, as if you were in the same room. Real-time conversations will pulse through the virtual corridors, injecting life into our co-working spaces and fostering a sense of true camaraderie. It's akin to breaking down the barriers of distance, allowing connections to flourish in a space where the digital and physical worlds converge. With this, VOffice will become a haven for remote teams, a sanctuary where collaboration knows no bounds. 🌐🚀

The addition of webviewers is set to revolutionize the way we interact with information within VOffice. Picture a window to the world wide web, seamlessly integrated into our virtual environment. Need to research, gather data, or simply browse for inspiration? It's all just a click away. This feature not only enriches the user experience but also empowers entrepreneurs and teams with a wealth of resources at their fingertips. It's akin to having an entire library within reach, ready to be explored without ever leaving the immersive realm of VOffice. The future is vibrant, filled with opportunities for limitless growth and productivity. 🌍🔍

<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE.txt` for more information.

<!-- CONTACT -->
## Contact

If you would like to find out more information about our project, feel free to reach out to us on LinkedIn:

- Ryan Nguyen - [LinkedIn](https://www.linkedin.com/in/ryan-nguyen-0aa676218/)
- Stephen Ni - [LinkedIn](https://www.linkedin.com/in/stephen-ni/)
- Ian Korovinsky - [LinkedIn](https://www.linkedin.com/in/ian-korovinsky/)
- Henry Wang - [LinkedIn](https://www.linkedin.com/in/henry-wang-38a4a4265/)
- Eric Zhang - [LinkedIn](https://www.linkedin.com/in/eric-s-zhang/)

<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/16BitNarwhal/Innovation-Challenge.svg?style=for-the-badge
[contributors-url]: https://github.com/16BitNarwhal/Innovation-Challenge/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/16BitNarwhal/Innovation-Challenge.svg?style=for-the-badge
[forks-url]: https://github.com/16BitNarwhal/Innovation-Challenge/network/members
[stars-shield]: https://img.shields.io/github/stars/16BitNarwhal/Innovation-Challenge.svg?style=for-the-badge
[stars-url]: https://github.com/16BitNarwhal/Innovation-Challenge/stargazers
[issues-shield]: https://img.shields.io/github/issues/16BitNarwhal/Innovation-Challenge.svg?style=for-the-badge
[issues-url]: https://github.com/16BitNarwhal/Innovation-Challenge/issues
[license-shield]: https://img.shields.io/github/license/othneildrew/Best-README-Template.svg?style=for-the-badge
[license-url]: https://opensource.org/license/mit/
[commits-shield]:https://img.shields.io/github/commit-activity/t/16BitNarwhal/Innovation-Challenge.svg?style=for-the-badge
[commits-url]:https://github.com/16BitNarwhal/Innovation-Challenge/commits
[pull-requests-shield]:https://img.shields.io/github/issues-pr/16BitNarwhal/Innovation-Challenge.svg?style=for-the-badge
[pull-requests-url]:https://github.com/16BitNarwhal/Innovation-Challenge/pulls
[code-size-shield]:https://img.shields.io/github/languages/code-size/16BitNarwhal/Innovation-Challenge.svg?style=for-the-badge
[tests-passing-shield]: https://img.shields.io/github/actions/workflow/status/:user/Innovation-Challenge.svg?style=for-the-badge
[product-screenshot]: interface.png
[Next.js]: https://img.shields.io/badge/next.js-808080?style=for-the-badge&logo=nextdotjs&logoColor=white
[Next-url]: https://nextjs.org/
[Python]: https://img.shields.io/badge/python-FF0000?style=for-the-badge&logo=python&logoColor=white
[Python-url]:https://www.python.org/
[Google-Cloud]:https://img.shields.io/badge/google_cloud-008000?style=for-the-badge&logo=googlecloud&logoColor=white
[Google-Cloud-url]:https://cloud.google.com/
[OpenCV]:https://img.shields.io/badge/opencv-0000FF?style=for-the-badge&logo=opencv&logoColor=white
[OpenCV-url]:https://opencv.org/
[OpenAI-Whisper]:https://img.shields.io/badge/openai_whisper-000000?style=for-the-badge&logo=openai&logoColor=white
[OpenAI-Whisper-url]:https://openai.com/research/whisper
[SciKit-Learn]:https://img.shields.io/badge/scikit_learn-FFC0CB?style=for-the-badge&logo=scikitlearn&logoColor=black
[SciKit-Learn-url]:https://scikit-learn.org/ 
