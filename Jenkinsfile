

pipeline {  
  environment {
	  theName = "${env.BRANCH_NAME.split("-")[1]}"
	  theNamed = "${env.BRANCH_NAME.split("-")[0]}"

     MSBuild15 = "E:\\JenkinsDependencies\\SonarQube\\SonarQube.Scanner.MSBuild.exe"
     DISTRIBUTION_SERVER = "C:\\Users\\RS\\Publish"     
     REPO_NAME = "WP.PaymentValidators.Test"
     PUBLISH_DIRECTORY = "${DISTRIBUTION_SERVER}\\${REPO_NAME}\\${env.BRANCH_NAME}"
     LONG_COMMIT_ID = "${GIT_COMMIT}"
     SHORT_COMMIT_ID = LONG_COMMIT_ID.substring(1, 8)
     DATE = System.currentTimeMillis() 
   }
  
  agent any
    stages {
        stage('Restore Package(s)...') {
            steps {
                echo 'Restore Package(s)'
            }
        }
        stage('Build') {
            steps {
                echo 'Building...'
               
            }
        }
       stage('Test') {
            steps {
                echo 'Testing..'
            }
        }
        stage('Publish - Master') {
               when { branch 'master' }
	    steps { 
		echo 'I only execute on the master branch.' 
	    	}             
        }
	    
	stage('Publish - Release') {
               when { branch "Release-*" }
	    steps { 
		    echo "${theName}"
		    
		    echo "${theNamed}"
		echo 'I only execute on the release branch.' 
	    	}             
        }
	    
	    
    }
}


