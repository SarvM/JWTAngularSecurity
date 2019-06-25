import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import { HttpClient, HttpHeaders } from '@angular/common/http';

import { Package } from './package.model';

const API_URL = "http://localhost:5000/api/package/";
const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json'
  })
};

@Injectable()
export class PackageService {

  constructor(private http: HttpClient) { }

  getPackages(): Observable<Package[]> {
    return this.http.get<Package[]>(API_URL);
  }

  enrollPackage(id: string): Observable<boolean> {
    return this.http.get<boolean>(API_URL + id.toString());
  }

}
