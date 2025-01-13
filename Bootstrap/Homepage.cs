<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>First b4 Web Page</title>
    <!-- bootstrap4 cdn-->
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css">
    <!--   <link rel="stylesheet" href="style.css">  -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.7.2/css/all.min.css" integrity="sha512-Evv84Mr4kqVGRNSgIGL/F/aIDqQb7xQ2vcrdIwxfjThSH8CSR7PBEakCr51Ck+w+/U6swU2Im1vVX0SVk9ABhg==
    " crossorigin="anonymous" referrerpolicy="no-referrer" />

    <style>

    </style>
</head>

<body>

    <!--Container = add padding; Container-fluid= full screen view-->

    <!--Row-Column Create-->
    <!--
    <div class="container">
    <div>
        <h1>Study With momo</h1>
        <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime quae quaerat nam molestiae provident quam? 
        Debitis temporibus quaerat, natus nisi velit, reiciendis eos quae molestiae magnam placeat repellendus! Fugit, ipsa?</p>
    </div>

    <div>
        <h1>Study With momo</h1>
        <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime quae quaerat nam molestiae provident quam? 
        Debitis temporibus quaerat, natus nisi velit, reiciendis eos quae molestiae magnam placeat repellendus! Fugit, ipsa?</p>
    </div>

    <div>
        <h1>Study With momo</h1>
        <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime quae quaerat nam molestiae provident quam? 
        Debitis temporibus quaerat, natus nisi velit, reiciendis eos quae molestiae magnam placeat repellendus! Fugit, ipsa?</p>
    </div>
  </div>
    -->





    <!-- <div class="container">
        <div class="row">
            <div class="col-lg-3 col-md-6 col-sm-12">
                <h1>Study With momo1</h1>
                <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime quae quaerat nam molestiae provident
                    quam?
                    Debitis temporibus quaerat, natus nisi velit, reiciendis eos quae molestiae magnam placeat
                    repellendus! Fugit, ipsa?</p>
            </div>

            <div class="col-lg-3 col-md-6 col-sm-12">
                <h1>Study With momo2</h1>
                <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime quae quaerat nam molestiae provident
                    quam?
                    Debitis temporibus quaerat, natus nisi velit, reiciendis eos quae molestiae magnam placeat
                    repellendus! Fugit, ipsa?</p>
            </div>

            <div class="col-lg-3 col-md-6 col-sm-12">
                <h1>Study With momo3</h1>
                <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime quae quaerat nam molestiae provident
                    quam?
                    Debitis temporibus quaerat, natus nisi velit, reiciendis eos quae molestiae magnam placeat
                    repellendus! Fugit, ipsa?</p>
            </div>

            <div class="col-lg-3 col-md-6 col-sm-12">
                <h1>Study With momo4</h1>
                <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime quae quaerat nam molestiae provident
                    quam?
                    Debitis temporibus quaerat, natus nisi velit, reiciendis eos quae molestiae magnam placeat
                    repellendus! Fugit, ipsa?</p>
            </div>
        </div>

    </div> -->

    <header class="bg-dark py-2">
        <div class="container-fluid">

            <div class="row align-items-center">
                <!-- Left Section -->
                <div class="col-lg-5">
                    <h3 class="text-warning mb-0">CV Generator</h3>

                </div>

                <!-- Right Section -->
                <div class="col-lg-7">
                    <div class="d-flex justify-content-end">
                        <button type="button"
                            class="btn btn-link me-3 text-decoration-none text-secondary fw-bold">Contact Us</button>
                        <button type="button"
                            class="btn btn-link me-3 text-decoration-none text-secondary fw-bold">FAQ</button>
                        <button type="button" class="btn btn-outline-secondary me-3 fw-bold text-white">Login</button>
                        <button type="button" class="btn btn-warning fw-bold">Sign Up</button>
                    </div>
                </div>

            </div>
        </div>
    </header>

    <main>

        <div class="container text-center p-5 mt-5">
            <div class="p-6 ">
                <h1 class=" display-3 text-dark"><b>Create a Professional CV</b></h1>
                <h5 class="text-secondary font-weight-light ">Fill in the blanks, choose a template and download your CV in <br>minutes.</h5>
                <button type="button" class="btn btn-warning text-dark btn-lg mt-4">Create CV</button>
            </div>
        </div>

        
        <div class="container my-5">
            <!-- Header -->
            <h1 class="text-center mb-4">Everything about a CV for a Job<br> Application</h1>
            
            <!-- Accordion -->
            <div class="accordion px-5" id="cvAccordion">
                <!-- Item 1 -->
                <div class="accordion-item">
                    <h2 class="accordion-header" id="headingOne">
                        <button class="accordion-button" type="button" data-bs-toggle="collapse" data-bs-target="#collapseOne" aria-expanded="false" aria-controls="collapseOne">
                            What is a CV?
                        </button>
                    </h2>
                    <div id="collapseOne" class="accordion-collapse collapse" aria-labelledby="headingOne" data-bs-parent="#cvAccordion">
                        <div class="accordion-body">
                            <p class="text-justify">Writing a CV involves presenting your skills, education, experiences, and achievements
                             in a clear and professional manner to impress potential employers. Start with your **personal details** like your full 
                             name, phone number, email, and links to professional profiles (e.g., LinkedIn or GitHub). Follow this with a **professional
                              summary**, a brief paragraph highlighting your key skills, accomplishments, and career goals. Next, list your **education**,
                               including your degree, institution, and graduation date. Include any notable achievements or relevant coursework. Then,
                                showcase your **skills**, dividing them into technical (like programming languages and tools) and soft skills (like teamwork 
                                or communication). Detail your **work experience** or **projects** by describing your responsibilities, tasks, and accomplishments,
                                 using bullet points for clarity. Add a section for **achievements** like awards, certifications, or extracurricular activities. Ensure
                                  the CV is concise, tailored to the job you're applying for, and formatted neatly to be easy to read.</p>
                        </div>
                    </div>
                </div>
        
                <!-- Item 2 -->
                <div class="accordion-item">
                    <h2 class="accordion-header" id="headingTwo">
                        <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapseTwo" aria-expanded="false" aria-controls="collapseTwo">
                            What to include in a CV?
                        </button>
                    </h2>
                    <div id="collapseTwo" class="accordion-collapse collapse" aria-labelledby="headingTwo" data-bs-parent="#cvAccordion">
                        <div class="accordion-body">
                            <p class="text-justify">A well-rounded CV includes essential sections such as personal information, a professional summary, education, skills, work experience or projects, achievements, and, optionally, interests. The personal information section provides your contact details, while the professional summary offers a brief overview of your key skills and career goals. The education section outlines your academic background, including degrees, institutions, and notable achievements. Skills are divided into technical and soft skills, demonstrating your proficiency in
                             relevant areas. Work experience or projects should highlight your roles, responsibilities, and accomplishments using concise bullet points. Additionally, showcasing achievements like certifications, awards, or extracurricular activities strengthens your CV. Finally, if applicable, include a section for interests that reflect your passion and engagement within your field. Tailoring your CV to align with the job description ensures a strong, personalized application.</p>
                        </div>
                    </div>
                </div>
        
                <!-- Item 3 -->
                <div class="accordion-item">
                    <h2 class="accordion-header" id="headingThree">
                        <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapseThree" aria-expanded="false" aria-controls="collapseThree">
                            What is the purpose of a CV?
                        </button>
                    </h2>
                    <div id="collapseThree" class="accordion-collapse collapse" aria-labelledby="headingThree" data-bs-parent="#cvAccordion">
                        <div class="accordion-body">
                            <p class="text-justify">The primary purpose of a CV (Curriculum Vitae) is to provide a detailed overview of an individual’s professional background, skills, and achievements to potential employers, educational institutions, or organizations. It serves as a critical tool for job applications, allowing candidates to effectively communicate their qualifications, work experience, and capabilities. A well-structured CV highlights educational accomplishments, technical and soft skills, relevant work or project experiences, and unique achievements that demonstrate the applicant’s suitability for the role. Additionally, it helps employers quickly assess a candidate’s compatibility with the job requirements and stand out from other applicants. Ultimately, a CV plays a vital 
                            role in securing interviews and opportunities by presenting a polished and professional representation of an individual’s career journey.</p>
                        </div>
                    </div>
                </div>
        
                <!-- Item 4 -->
                <div class="accordion-item">
                    <h2 class="accordion-header" id="headingFour">
                        <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapseFour" aria-expanded="false" aria-controls="collapseFour">
                            How to write a CV?
                        </button>
                    </h2>
                    <div id="collapseFour" class="accordion-collapse collapse" aria-labelledby="headingFour" data-bs-parent="#cvAccordion">
                        <div class="accordion-body">
                           <p class="text-justify">To write a CV, start by including essential personal information such as your full name, contact details (email, phone number), and LinkedIn profile (optional). Next, craft a professional summary that briefly highlights your skills, strengths, and career goals. Following this, outline your educational background, including degrees, institutions, and relevant achievements. Highlight your skills, separating them into technical and soft categories to showcase your proficiency. Then, provide work experience or project details, using bullet points to describe responsibilities and key accomplishments. Additionally, include any relevant achievements like certifications, awards, or extracurricular activities. Finally, ensure your CV is well-organized, concise, and tailored to the specific role you’re 
                            applying for. This structure helps create a polished and impactful CV that effectively communicates your qualifications to potential employers.</p>
                        </div>
                    </div>
                </div>
        
                <!-- Add more accordion items as needed -->
            </div>
        </div>
        
        

    </main>

  



    <footer class="bg-dark text-white text-center py-1">
        <div class="container">
            <p class="mb-0">&copy; 2025 Your Website Name. All Rights Reserved.</p>
            <div class="social-icons mt-2">
                <a href="#" class="text-white me-3"><i class="fab fa-facebook-f"></i></a>
                <a href="#" class="text-white me-3"><i class="fab fa-twitter"></i></a>
                <a href="#" class="text-white me-3"><i class="fab fa-linkedin-in"></i></a>
                <a href="#" class="text-white"><i class="fab fa-instagram"></i></a>
            </div>
        </div>
    </footer>
    








    <!--bootstrap4 js,query-->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>
</body>

</html>
