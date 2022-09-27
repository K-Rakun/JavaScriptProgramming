# -*- coding: utf-8 -*-
import unittest
import time

from webdriver_manager.chrome import ChromeDriverManager


from selenium import webdriver
from selenium.webdriver.common.by import By
from selenium.webdriver.common.keys import Keys
from selenium.webdriver.support.ui import Select
from selenium.common.exceptions import NoSuchElementException
from selenium.common.exceptions import NoAlertPresentException
import unittest, time, re

from settings import USERNAME, PASSWORD 

class DecTestCase(unittest.TestCase):
    def setUp(self):

        
        self.driver = webdriver.Chrome(r"C:\Users\casper\Desktop\chromedriver_win32\chromedriver.exe")
        self.driver.implicitly_wait(30)
        self.base_url = "http://dec.vumk.eu/student/web/site/login"
        self.verificationErrors = []
        self.accept_next_alert = True
    
    def test_login(self):
        driver = self.driver
        driver.get(self.base_url)
        user = driver.find_element_by_id("UserLoginForm_username")
        user.click()
        user.clear()
        user.send_keys(USERNAME)
        password = driver.find_element_by_id("UserLoginForm_password")
        password.click()
        password.clear()
        password.send_keys(PASSWORD)
        login = driver.find_element_by_id("login-content-button")
        login.click()
        time.sleep(2)
        self.assertEqual(driver.current_url, "http://dec.vumk.eu/student/web/")
        time.sleep(10)

    
    def is_element_present(self, how, what):
        try: self.driver.find_element(by=how, value=what)
        except NoSuchElementException as e: return False
        return True
    

    
    def tearDown(self):
        self.driver.quit()

if __name__ == "__main__":
    unittest.main()
