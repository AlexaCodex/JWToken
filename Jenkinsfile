

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
            steps {
                echo 'Publishing...'
                
		echo 'Creating Build_Offline.txt...'
                writeFile file: "${PUBLISH_DIRECTORY}\\build_offline.htm", text: """<html>
                <title>${REPO_NAME} - ${env.BRANCH_NAME} - ${SHORT_COMMIT_ID}</title>
                <body>
                <strong>${REPO_NAME} - ${env.BRANCH_NAME} - ${SHORT_COMMIT_ID}</strong>
                <ul>
                <li><small>0.0.0.${env.BUILD_ID}</small></li>
                <li><small>${new Date().format('dd MM yyyy hh:mm:ss')}</small></li>
                <li><small>${REPO_NAME} - ${env.BRANCH_NAME}</small></li>
                <li><small>#${env.BUILD_ID}</small></li>
                </ul>
                </body>
                </html>"""
            }
        }
    }
}


