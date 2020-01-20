import { Component, OnInit } from '@angular/core';
import { GalleryService } from '../services/gallery.service';

@Component({
  selector: 'app-gallery',
  templateUrl: './gallery.component.html',
  styleUrls: ['./gallery.component.scss']
})
export class GalleryComponent implements OnInit {
  genres: any[];
  isEnables = false;
  constructor(private galleryService: GalleryService) { }

  ngOnInit() {
    this.galleryService.getGenres().subscribe(
      (resp)=>{
        this.genres = resp;
      },
      err => {
        console.log(err);
      }
    );
  }


}
