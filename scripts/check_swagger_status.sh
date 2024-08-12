#!/usr/bin/env bash

# Initialize the retry counter and the max retry time
retry_counter=0
max_retry_time=10

# Function to check the status code
check_status() {
  http_status=$(curl -o /dev/null -s -w "%{http_code}" https://wfapi.uds.dev/swagger/index.html)

  if [ "$http_status" -eq 200 ]; then
    return 0
  else
    return 1
  fi
}

# Loop to retry the request until success or timeout
while [ $retry_counter -lt $max_retry_time ]; do
  if check_status; then
    echo "Success: Status 200 received."
    exit 0
  else
    echo "Attempt $((retry_counter + 1)): Status not 200, retrying..."
    retry_counter=$((retry_counter + 1))
    sleep 1
  fi
done

# If the loop ends, it means the max retry time was reached
echo "Failed: Could not get a 200 status code after $max_retry_time seconds."
exit 1
