import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class GalleryService {

constructor(private http: HttpClient) { }

getGenres() {
  return this.http
    .get('http://localhost:53413/api/genres')
    .pipe(
      map((resp: any)=>{
        return resp;
      })
    );

}
}
