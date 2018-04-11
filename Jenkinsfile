

pipeline {  
  environment {
	  def branchName = "Release-2.132"
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
        stage('Publish') {
            
                echo 'Publishing...'
		    
		      if (env.BRANCH_NAME == 'master') {
			    echo 'I only execute on the master branch'
			} else {
			    echo 'I execute elsewhere'
			}
                
            
        }
    }
}


