import { rejects } from "assert";
import axios, { AxiosError, AxiosResponse } from "axios";
import { request } from "http";
import { Assignment, AssignmentFormValues } from "../models/assignment";


const sleep = (delay: number) => {
    return new Promise((resolve) => {
        setTimeout(resolve, delay)
    });
}

axios.defaults.baseURL = process.env.REACT_APP_API_URL;

/*
axios.interceptors.request.use(config => {

});
*/

// can expand error handling
axios.interceptors.response.use(async response => {
    if (process.env.NODE_ENV === 'development') await sleep(1000); //delay response slightly
    return response;
}, (error: AxiosError) => {
    const {data, status, config} = error.response!;
    switch(status) {
        case 400:
            if (typeof data === 'string')
                console.log("400 error");
            break;
    }
    return Promise.reject(error);
});

const responseBody = <T> (response: AxiosResponse<T>) => response.data;

const requests = {
    get: <T> (url: string) => axios.get<T>(url).then(responseBody),
    post: <T> (url: string, body: {}) => axios.post<T>(url, body).then(responseBody),
    put: <T> (url: string, body: {}) => axios.put<T>(url, body).then(responseBody),
    del: <T> (url: string) => axios.delete<T>(url).then(responseBody),
}

const Assignments = {
    
    details: (id: string) => requests.get<Assignment>(`/assignments/${id}`),
    create: (assignment: AssignmentFormValues) => requests.post<void>('/assignments', assignment),
    update: (assignment: AssignmentFormValues) => requests.put<void>(`'assignments/${assignment.id}`, assignment),
    delete: (id: string) => requests.del<void>(`/assignments/${id}`),
}

const agent = {
    Assignments
}

export default agent;