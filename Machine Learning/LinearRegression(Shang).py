#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Thu Feb  8 13:29:03 2018
@author: Zhuocheng Shang
"""
#import statement
import numpy as np
from scipy.optimize import minimize
from scipy.stats import norm

#define a single class linearRegression
class LinearRegression:
    def __init__(self,X,y):
        #initialize all attributes
        self.data = np.array(X) #2d-array
        self.labels = np.array(y)
        self.n_observations = len(y)
        
        def find_sse(beta):
            #y_hat
            y_hat = beta[0] + np.sum(beta[1:] * self.data, axis=1)
            #residuals <= y-y_hat
            residuals = self.labels - y_hat
            #sse
            sse = np.sum(residuals**2)         
            return sse
        
        #inital "guess"  # self.coefficients
        beta_guess = np.zeros(self.data.shape[1] + 1) 
        min_results = minimize(find_sse, beta_guess) 
        self.coefficients = min_results.x
        
        #calsulate y_predicted
        self.y_predicted = self.predict(self.data)

        #calculate residuals
        self.residuals = self.labels - self.y_predicted

        #calculate sse
        self.sse = np.sum(self.residuals**2) 

        #calculate r_squared
        mean_y = np.mean(self.labels)
        self.sst = np.sum((self.labels - mean_y)**2)
        self.r_squared = 1-(self.sse / self.sst)

        #calculate rse
        self.rse = (self.sse / (self.n_observations -2)) ** 0.5

        #calculate loglik
        self.loglik = np.sum(np.log(norm.pdf(self.residuals,0,self.rse)))
        
    def predict(self,X):
        new_X = np.array(X)
        new_y_predicted = self.coefficients[0] + np.sum(self.coefficients[1:] * new_X,axis=1)
        return new_y_predicted
        
    def score(self,X,y):
        #correct x and y to numpy array
        X_value = np.array(X)
        y_label = np.array(y)
        #calculate predict
        y_hat = self.predict(X_value)
        residuals = y_label-y_hat
        #calculate sse
        sse = np.sum(residuals**2) 
        #calculate r_squared
        mean_y = np.mean(y_label)
        sst = np.sum((y_label - mean_y)**2)
        r_squared = 1-sse / sst
        return r_squared
    
    def summary(self):
        print('+----------------------------+')
        print('|  Split Classifier Summary  |')
        print('+----------------------------+')
        print('Number of training observations:' ,self.n_observations,'\n')
        print('Coefficient Estimates:',self.coefficients,'\n')
        print('Residual Standard Error:',self.rse,'\n' )
        print('r-Squared:',self.r_squared,'\n')
        print('Log-Likelihood:',self.loglik,'\n')


#test code go below

