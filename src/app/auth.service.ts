import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http'

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(private http: HttpClient) { }

  getUSerDetails(username, password) {
    return this.http.post('https://localhost:5001/api/users',
    {
      username,
      password
    }).subscribe(data => {
      console.log(data, "data from the server")
    })
  }
}
